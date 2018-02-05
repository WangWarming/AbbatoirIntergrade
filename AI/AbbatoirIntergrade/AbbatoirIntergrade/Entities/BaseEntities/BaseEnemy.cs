using System;
using System.Threading;
using AbbatoirIntergrade.Entities.Projectiles;
using AbbatoirIntergrade.StaticManagers;
using AbbatoirIntergrade.UtilityClasses;
using Accord.Genetic;
using FlatRedBall;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Math;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using StateInterpolationPlugin;

namespace AbbatoirIntergrade.Entities.BaseEntities
{
	public partial class BaseEnemy
	{
        private bool _AddedToLayers = false;

        public event Action<BaseEnemy> OnDeath;
	    public float Altitude { get; protected set; }
	    protected float AltitudeVelocity { get; set; }
	    protected float GravityDrag { get; set; } = -650f;

        public double HealthRemaining { get; set; }

        public bool IsDead => HealthRemaining <= 0;
	    private bool IsHurt => CurrentActionState == Action.Hurt;
	    protected bool IsPoisoned => _poisonedDurationSeconds > 0;
	    protected bool IsFrozen => _frostDurationSeconds > 0;
	    protected bool IsStunned => _stunnedDurationSeconds > 0;
	    protected bool IsBurning => _burnDurationSeconds > 0;
	    private double _frostDurationSeconds;
	    private double _poisonedDurationSeconds;
	    private double _stunnedDurationSeconds;
	    private double _burnDurationSeconds;

	    private double _poisonDamagePerSecond;
	    private double _frostDamagePerSecond;
	    private double _burnDamagePerSecond;

	    private bool IsOnFinalFrameOfAnimation => SpriteInstance.CurrentFrameIndex == SpriteInstance.CurrentChain.Count - 1;

        private float? _startingShadowWidth;
	    private float _startingShadowHeight;
	    private float _startingShadowAlpha;
	    private float _startingLightScale;
	    private AnimationChainList spriteAnimationChainList;
	    private bool IsDrowning => CurrentActionState == Action.Drowning;

        protected float _spriteRelativeY;

        protected SoundEffectInstance DeathSound;
	    protected SoundEffectInstance drowningSound;


        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
		{
#if DEBUG
		    if (DebugVariables.ShowDebugShapes)
		    {
		        SelfCollisionCircle.Visible = true;

                if (CircleInstance != null) CircleInstance.Visible = true;
                if (AxisAlignedRectangleInstance != null) AxisAlignedRectangleInstance.Visible = true;
		    }
		    else
#endif
		    {
		        SelfCollisionCircle.Visible = false;
                if (CircleInstance != null) CircleInstance.Visible = false;
		        if (AxisAlignedRectangleInstance != null) AxisAlignedRectangleInstance.Visible = false;
            }

		    if (!_startingShadowWidth.HasValue)
		    {
		        _startingLightScale = LightSprite.TextureScale;
		        _startingShadowWidth = ShadowSprite.Width;
		        _startingShadowHeight = ShadowSprite.Height;
		        _startingShadowAlpha = ShadowSprite.Alpha;

		        _spriteRelativeY = SpriteInstance.Height / 2;
		        spriteAnimationChainList = SpriteInstance.AnimationChains;

		        PoisonedParticles.ScaleX = SpriteInstance.Width / 2;
		        PoisonedParticles.ScaleY = SpriteInstance.Height / 2;
		        PoisonedParticles.RelativeY = SpriteInstance.Height / 2;
		        PoisonedParticles.TimedEmission = false;

		        FrozenParticles.ScaleX = SpriteInstance.Width / 2;
		        FrozenParticles.ScaleY = SpriteInstance.Height / 2;
		        FrozenParticles.RelativeY = SpriteInstance.Height / 2;
		        FrozenParticles.TimedEmission = false;

		        SmokeParticles.ScaleX = SpriteInstance.Width / 2;
		        SmokeParticles.ScaleY = SpriteInstance.Height / 2;
		        SmokeParticles.RelativeY = SpriteInstance.Height / 2;
		        SmokeParticles.TimedEmission = false;

		        StunParticles.ScaleX = SpriteInstance.Width / 2;
		        StunParticles.ScaleY = SpriteInstance.Height / 2;
		        StunParticles.RelativeY = SpriteInstance.Height / 2;
		        StunParticles.TimedEmission = false;
            }

		    if (drowningSound == null || drowningSound.IsDisposed)
		    {
		        drowningSound = DrowningSound.CreateInstance();
		    }

		    SpriteInstance.AnimationChains = spriteAnimationChainList;

            ShadowSprite.RelativeY = 0;
		    ShadowSprite.Visible = true;
            
            HasReachedGoal = false;

            HealthBar.AttachTo(SpriteInstance, true);
            //HealthBar.UpdateDependencies(TimeManager.CurrentTime);
            HealthBar.SetWidth(SpriteInstance.Width);
		    HealthBar.RelativeY = HealthBar.Height + GetMaxFrameHeight();
            HealthBar.Hide();

            HealthRemaining = MaximumHealth;
		    Altitude = 0f;
		    AltitudeVelocity = 0f;

		    _poisonedDurationSeconds = 0;
		    _frostDurationSeconds = 0;
		    _burnDurationSeconds = 0;
		    _stunnedDurationSeconds = 0;

		    EffectiveSpeed = BaseSpeed;



            SetAttributes();

		    SetGenetics();

            UpdateAnimation();
		}

	    private void SetAttributes()
	    {
	        var enemyName = GetType().Name.Replace("Enemy", "");
	        var csvEntry = GlobalContent.Enemy_Attributes[enemyName];

	        BaseHealth = csvEntry.Health;
	        BaseSpeed = csvEntry.Speed;

	        BaseBombardResist = csvEntry.BombardResist;
	        BasePiercingResist = csvEntry.PiercingResist;
	        BaseChemicalResist = csvEntry.ChemicalResist;
	        BaseFrostResist = csvEntry.FrostResist;
	        BaseFireResist = csvEntry.FireResist;
	        BaseElectricResist = csvEntry.ElectricResist;
	        IsFlying = csvEntry.IsFlying;
	    }

	    private float GetMaxFrameHeight()
	    {
	        if (!SpriteInstanceAnimate || SpriteInstance.CurrentChain.Count == 1) return SpriteInstance.Height;
	        else
	        {
	            var largestHeight = 0f;
	            for (var i = 0; i < SpriteInstance.CurrentChain.Count - 1; i++)
	            {
	                var frame = SpriteInstance.CurrentChain[i];
	                largestHeight = Math.Max(largestHeight, (frame.BottomCoordinate - frame.TopCoordinate) * frame.Texture.Height);
	            }
	            return largestHeight;
	        }
	    }

	    private void CustomActivity()
		{
            UpdateStatusEffect();

            if (!IsFlying || (IsFlying && IsDead))
		    {
                AltitudeVelocity += GravityDrag * TimeManager.SecondDifference;
            }

		    if (AltitudeVelocity > 0 || (Altitude > 0 && AltitudeVelocity < 0))
		    {
                //Remove drag in the air
		        Drag = 0.1f;
		        Altitude = Math.Max(0, Altitude + AltitudeVelocity * TimeManager.SecondDifference);
		        if (IsHurt && IsOnFinalFrameOfAnimation) SpriteInstance.Animate = false;
		    }

            if (Math.Abs(Altitude) <= 0.001f && AltitudeVelocity < 0)
            {
                //Reset drag by setting state
                CurrentActionState = CurrentActionState;
                Altitude = 0;
		        AltitudeVelocity = 0;
                if (!IsStunned || IsFlying) SpriteInstance.Animate = true;
            }

            if (IsDead)
		    {
                PerformDeath();
		    }
		    else if (IsHurt && SpriteInstance.JustCycled)
		    {
		        CurrentActionState = Action.Standing;
		    }

		    if (!IsDead && !IsHurt)
		    {
		        NavigationActivity();
		        SetDirection();
		    }

		    UpdateAnimation();
            UpdateHealthBar();
		}

        private void UpdateAnimation()
	    {
            //_spriteRelativeY = SpriteInstance.Height / 2;

	        SpriteInstance.RelativeY = Altitude + _spriteRelativeY + SpriteInstance.CurrentChain[SpriteInstance.CurrentFrameIndex].RelativeY;

	        var pctLightShadow = MathHelper.Clamp(1 - (Altitude / (800)), 0, 1);

	        ShadowSprite.Width = _startingShadowWidth.Value * pctLightShadow;
	        ShadowSprite.Height = _startingShadowHeight * pctLightShadow;
	        ShadowSprite.Alpha = _startingShadowAlpha * pctLightShadow;

	        if (HasLightSource)
	        {
	            LightSprite.TextureScale = _startingLightScale;
	            LightSprite.RelativeY = SpriteInstance.RelativeY;
	        }
        }

	    protected void SetDirection()
	    {
	        CurrentDirectionState =
	            (Velocity.X < 0 ? Direction.MovingLeft : Direction.MovingRight);
	        SpriteInstance.IgnoreAnimationChainTextureFlip = true;
	    }

        private void UpdateHealthBar()
	    {
	        if (IsDead || HealthRemaining >= MaximumHealth)
	        {
	            HealthBar.Hide();
	        }
	        else 
	        {
                HealthBar.Update(HealthRemaining/MaximumHealth);
            }
        }

	    private void TakeDamage(double dmgAmount)
	    {
	        HealthRemaining -= dmgAmount;

	        if (HealthRemaining <= 0)
	        {
	            PerformDeath();
	        }
        }

        public void GetHitBy(BasePlayerProjectile projectile, float dmgMultiplier = 1)
        {
            var effectiveMultiplier = GetEffectiveMultiplier(projectile.DamageType);
            var dmgInflicted = effectiveMultiplier * projectile.DamageInflicted * dmgMultiplier;
            TakeDamage(dmgInflicted);

            var shouldBeHurt = true;

	        switch (projectile.DamageType)
	        {
	            case DamageTypes.Frost:
	                _frostDurationSeconds = projectile.StatusEffectSeconds * effectiveMultiplier;
	                _frostDamagePerSecond = dmgInflicted * projectile.StatusDamageMultiplier;
	                _burnDurationSeconds = 0;
	                shouldBeHurt = false;
                    break;
	            case DamageTypes.Chemical:
	                _poisonedDurationSeconds = projectile.StatusEffectSeconds * effectiveMultiplier;
	                _poisonDamagePerSecond = dmgInflicted * projectile.StatusDamageMultiplier;
	                shouldBeHurt = false;
                    break;
	            case DamageTypes.Electrical:
	                _stunnedDurationSeconds = projectile.StatusEffectSeconds * effectiveMultiplier;
                    break;
	            case DamageTypes.Fire:
	                _burnDurationSeconds = projectile.StatusEffectSeconds * effectiveMultiplier;
	                _burnDamagePerSecond = dmgInflicted * projectile.StatusDamageMultiplier;
	                _frostDurationSeconds = 0;
                    break;
            }
	        UpdateStatusEffect(justApplied: true);

	        if (!IsDead && shouldBeHurt)
	        {
                CurrentActionState = Action.Hurt;
                SpriteInstance.UpdateToCurrentAnimationFrame();
	            UpdateAnimation();
	        }
	    }

	    private double GetEffectiveMultiplier(DamageTypes damageType)
	    {
	        switch (damageType)
	        {
	            case DamageTypes.Frost: return (1f - EffectiveFrostResist);
	            case DamageTypes.Chemical: return (1f - EffectiveChemicalResist);
	            case DamageTypes.Electrical: return (1f - BaseElectricResist);
	            case DamageTypes.Piercing: return (1f -EffectivePiercingResist);
                case DamageTypes.Bombarding: return (1f - EffectiveBombardResist);
                case DamageTypes.Fire: return (1f - EffectiveFireResist);
                default: return 1;
            }
        }

	    private void UpdateStatusEffect(bool justApplied = false)
	    {
	        if (!justApplied)
	        {
	            if (IsPoisoned)
	            {
	                _poisonedDurationSeconds -= TimeManager.SecondDifference;
	            }
	            if (IsFrozen)
	            {
	                _frostDurationSeconds -= TimeManager.SecondDifference;
	            }
	            if (IsStunned)
	            {
	                _stunnedDurationSeconds -= TimeManager.SecondDifference;
	            }
	            if (IsBurning)
	            {
	                _burnDurationSeconds -= TimeManager.SecondDifference;
	            }
	        }

	        if (IsFrozen && IsPoisoned)
	        {
	            CurrentStatusState = Status.FrozenAndPoisoned;
	            EffectiveSpeed = BaseSpeed * (1 - (float)(GetEffectiveMultiplier(DamageTypes.Frost) * 0.8 +
	                                     GetEffectiveMultiplier(DamageTypes.Chemical) * 0.2));
                
	        }
            else if (IsBurning && IsPoisoned)
	        {
	            CurrentStatusState = Status.BurningAndPoisoned;
	            EffectiveSpeed = BaseSpeed * (1 - (float)(GetEffectiveMultiplier(DamageTypes.Chemical) * 0.2));
            }
            else if (IsBurning)
	        {
	            CurrentStatusState = Status.Burning;
	        }
            else if (IsFrozen)
	        {
	            CurrentStatusState = Status.Frozen;
	            EffectiveSpeed = BaseSpeed * (1 - (float)(GetEffectiveMultiplier(DamageTypes.Frost) * 0.8));
            }
            else if (IsPoisoned)
	        {
	            CurrentStatusState = Status.Poisoned;
	            EffectiveSpeed = BaseSpeed * (1 - (float)(GetEffectiveMultiplier(DamageTypes.Chemical) * 0.2));
            }
            else if (IsStunned)
	        {
	            EffectiveSpeed = 0f;
	        }
	        else
	        {
	            CurrentStatusState = Status.Normal;
	            EffectiveSpeed = BaseSpeed;
	        }

	        FrozenParticles.TimedEmission = IsFrozen;
	        PoisonedParticles.TimedEmission = IsPoisoned;
	        SmokeParticles.TimedEmission = IsBurning;
	        StunParticles.TimedEmission = IsStunned;

            if (!IsFlying && (EffectiveSpeed <= 0.01f || IsStunned))
	        {
	            SpriteInstanceAnimate = false;
	        }
	        else
	        {
	            SpriteInstanceAnimate = true;
	            SpriteInstance.AnimationSpeed = EffectiveSpeed / BaseSpeed;
	        }

	        if (!justApplied)
	        {
	            if (IsPoisoned) TakeDamage(_poisonDamagePerSecond * TimeManager.SecondDifference);
                if (IsFrozen) TakeDamage(_frostDamagePerSecond * TimeManager.SecondDifference);
                if (IsBurning) TakeDamage(_burnDamagePerSecond * TimeManager.SecondDifference);
            }
        }

	    private void PerformDeath()
	    {
            if (!IsDrowning && CurrentActionState != Action.Dying)
	        {
	            OnDeath?.Invoke(this);
	            OnDeath -= OnDeath;
                CurrentActionState = Action.Dying;
	            PlayDeathSound();
            }

	        if (SpriteInstanceAnimate && IsOnFinalFrameOfAnimation)
	        {
	            SpriteInstanceAnimate = false;
	        }

            if (Altitude <=0f && IsOnFinalFrameOfAnimation)
            {
                RemoveArrows();
                Destroy();
            }
	    }

	    private void PlayDeathSound()
	    {
	        var pan = Position.X / Camera.Main.OrthogonalWidth;
            DeathSound.Pan = pan;
	        SoundManager.PlaySoundEffect(DeathSound);
	    }

	    private void RemoveArrows()
	    {
	        foreach (var child in Children)
	        {
	            if (child is PiercingProjectile projectile)
	            {
	                TweenerManager.Self.StopAllTweenersOwnedBy(projectile);
                    projectile.Destroy();
	            }
	        }
	    }

	    private void CustomDestroy()
		{
		    if (drowningSound != null && !drowningSound.IsDisposed)
		    {
                drowningSound.Stop(true);
                drowningSound.Dispose();
		    }

		    if (DeathSound != null && !DeathSound.IsDisposed) 
		    {
		        DeathSound.Stop(true);
		        DeathSound.Dispose();
            }
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	    public void ReactToExplosion(BasePlayerProjectile projectile, float amplitude, Vector3 velocity, float altitudeVelocity)
	    {
	        GetHitBy(projectile, amplitude);

            AltitudeVelocity += altitudeVelocity;

	        Velocity = velocity;
	    }

	    protected void AddSpritesToLayers(FlatRedBall.Graphics.Layer worldLayer, FlatRedBall.Graphics.Layer darknessLayer, FlatRedBall.Graphics.Layer hudLayer)
	    {
	        if (_AddedToLayers)
	        {
	            darknessLayer.Remove(LightSprite);
	            if (CircleInstance != null) hudLayer.Remove(CircleInstance);
	            if (AxisAlignedRectangleInstance != null) hudLayer.Remove(AxisAlignedRectangleInstance);
	        }

	        StunParticles.LayerToEmitOn = worldLayer;
	        PoisonedParticles.LayerToEmitOn = worldLayer;
	        FrozenParticles.LayerToEmitOn = worldLayer;
            SmokeParticles.LayerToEmitOn = worldLayer;
            //MoveToLayer(worldLayer);
            HealthBar.MoveToLayer(hudLayer);
            SpriteManager.AddToLayer(SpriteInstance, worldLayer);
            SpriteManager.AddToLayer(LightSprite, darknessLayer);
	        SpriteManager.AddToLayer(ShadowSprite, worldLayer);
            if (CircleInstance != null) ShapeManager.AddToLayer(CircleInstance, hudLayer);
	        if (AxisAlignedRectangleInstance != null) ShapeManager.AddToLayer(AxisAlignedRectangleInstance, hudLayer);

            _AddedToLayers = true;
	    }

	    public void HandleDrowning()
	    {
	        if (IsDrowning) return;

	        _frostDurationSeconds = 0;
	        _burnDurationSeconds = 0;
	        _poisonedDurationSeconds = 0;
	        _stunnedDurationSeconds = 0;

	        PlayDrowningSound();
	        SpriteInstance.AnimationChains = ParticleAnimationsChainList;
	        ShadowSprite.Visible = false;
	        SpriteInstance.RelativeY = 0;
	        CurrentActionState = Action.Drowning;
	        HealthRemaining = 0;
	        Velocity = Vector3.Zero;
	    }

	    private void PlayDrowningSound()
	    {
	        var pan = Position.X / Camera.Main.OrthogonalWidth;
	        drowningSound.Pan = pan;
	        SoundManager.PlaySoundEffect(drowningSound);
	    }

	    public EnemyTypes GetEnemyType()
	    {
	        var enemyName = GetType().Name.Replace("Enemy", "");
	        var enemyType = (EnemyTypes)Enum.Parse(typeof(EnemyTypes), enemyName);

	        return enemyType;
	    }
	}
}
