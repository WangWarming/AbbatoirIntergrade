#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using FlatRedBall.Gui;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall.Math.Geometry;
namespace AbbatoirIntergrade.Entities.Structures
{
    public partial class BombardingTower : AbbatoirIntergrade.Entities.BaseEntities.BaseStructure, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Performance.IPoolable, FlatRedBall.Graphics.IVisible, FlatRedBall.Gui.IClickable
    {
        // This is made static so that static lazy-loaded content can access it.
        public static new string ContentManagerName
        {
            get
            {
                return AbbatoirIntergrade.Entities.BaseEntities.BaseStructure.ContentManagerName;
            }
            set
            {
                AbbatoirIntergrade.Entities.BaseEntities.BaseStructure.ContentManagerName = value;
            }
        }
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        protected static Microsoft.Xna.Framework.Audio.SoundEffect CannonShot1;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect CannonShot2;
        
        public int Index { get; set; }
        public bool Used { get; set; }
        public new event System.EventHandler BeforeVisibleSet;
        public new event System.EventHandler AfterVisibleSet;
        public override bool Visible
        {
            get
            {
                return base.Visible;
            }
            set
            {
                if (BeforeVisibleSet != null)
                {
                    BeforeVisibleSet(this, null);
                }
                base.Visible = value;
                if (AfterVisibleSet != null)
                {
                    AfterVisibleSet(this, null);
                }
            }
        }
        System.Collections.Generic.List<GumCoreShared.FlatRedBall.Embedded.PositionedObjectGueWrapper> gumAttachmentWrappers = new System.Collections.Generic.List<GumCoreShared.FlatRedBall.Embedded.PositionedObjectGueWrapper>();
        public BombardingTower () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public BombardingTower (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public BombardingTower (string contentManagerName, bool addToManagers) 
        	: base(contentManagerName, addToManagers)
        {
            ContentManagerName = contentManagerName;
        }
        protected override void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            SpriteInstance = new FlatRedBall.Sprite();
            SpriteInstance.Name = "SpriteInstance";
            mAxisAlignedRectangleInstance = new FlatRedBall.Math.Geometry.AxisAlignedRectangle();
            mAxisAlignedRectangleInstance.Name = "mAxisAlignedRectangleInstance";
            LightSpriteInstance = new FlatRedBall.Sprite();
            LightSpriteInstance.Name = "LightSpriteInstance";
            AimSpriteInstance = new FlatRedBall.Sprite();
            AimSpriteInstance.Name = "AimSpriteInstance";
            PivotPoint = new FlatRedBall.PositionedObject();
            PivotPoint.Name = "PivotPoint";
            
            base.InitializeEntity(addToManagers);
        }
        public override void ReAddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            base.ReAddToManagers(layerToAddTo);
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mAxisAlignedRectangleInstance, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(LightSpriteInstance, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(AimSpriteInstance, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddPositionedObject(PivotPoint);
        }
        public override void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mAxisAlignedRectangleInstance, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(LightSpriteInstance, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(AimSpriteInstance, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddPositionedObject(PivotPoint);
            base.AddToManagers(layerToAddTo);
            CustomInitialize();
        }
        public override void Activity () 
        {
            base.Activity();
            
            CustomActivity();
        }
        public override void Destroy () 
        {
            if (Used)
            {
                Factories.BombardingTowerFactory.MakeUnused(this, false);
            }
            base.Destroy();
            
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            if (AxisAlignedRectangleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(AxisAlignedRectangleInstance);
            }
            if (LightSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(LightSpriteInstance);
            }
            if (AimSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(AimSpriteInstance);
            }
            if (PivotPoint != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(PivotPoint);
            }
            for (int i = gumAttachmentWrappers.Count-1; i > -1; i--)
            {
                FlatRedBall.SpriteManager.RemovePositionedObject(gumAttachmentWrappers[i]);
            }
            CustomDestroy();
        }
        public override void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            base.PostInitialize();
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.CopyAbsoluteToRelative();
                SpriteInstance.AttachTo(this, false);
            }
            base.SpriteInstance.Texture = AllParticles;
            base.SpriteInstance.LeftTexturePixel = 1949f;
            base.SpriteInstance.RightTexturePixel = 2037f;
            base.SpriteInstance.TopTexturePixel = 1724f;
            base.SpriteInstance.BottomTexturePixel = 1825f;
            base.SpriteInstance.TextureScale = 1f;
            base.SpriteInstance.UseAnimationRelativePosition = false;
            base.SpriteInstance.AnimationChains = BaseStructureAnimationChainListFile;
            base.SpriteInstance.CurrentChainName = "BombardingTower";
            if (mAxisAlignedRectangleInstance.Parent == null)
            {
                mAxisAlignedRectangleInstance.CopyAbsoluteToRelative();
                mAxisAlignedRectangleInstance.AttachTo(this, false);
            }
            base.AxisAlignedRectangleInstance.Width = 64f;
            base.AxisAlignedRectangleInstance.Height = 64f;
            if (LightSpriteInstance.Parent == null)
            {
                LightSpriteInstance.CopyAbsoluteToRelative();
                LightSpriteInstance.AttachTo(this, false);
            }
            if (LightSpriteInstance.Parent == null)
            {
                base.LightSpriteInstance.X = 0f;
            }
            else
            {
                base.LightSpriteInstance.RelativeX = 0f;
            }
            if (LightSpriteInstance.Parent == null)
            {
                base.LightSpriteInstance.Y = 30f;
            }
            else
            {
                base.LightSpriteInstance.RelativeY = 30f;
            }
            if (LightSpriteInstance.Parent == null)
            {
                base.LightSpriteInstance.Z = -1f;
            }
            else
            {
                base.LightSpriteInstance.RelativeZ = -1f;
            }
            base.LightSpriteInstance.LeftTexturePixel = 1792f;
            base.LightSpriteInstance.RightTexturePixel = 2048f;
            base.LightSpriteInstance.TopTexturePixel = 1792f;
            base.LightSpriteInstance.BottomTexturePixel = 2048f;
            base.LightSpriteInstance.TextureScale = 1f;
            #if FRB_MDX
            LightSpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.LightSpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.LightSpriteInstance.Blue = 0.5f;
            base.LightSpriteInstance.Alpha = 0.25f;
            if (AimSpriteInstance.Parent == null)
            {
                AimSpriteInstance.CopyAbsoluteToRelative();
                AimSpriteInstance.AttachTo(this, false);
            }
            if (AimSpriteInstance.Parent == null)
            {
                base.AimSpriteInstance.X = 0f;
            }
            else
            {
                base.AimSpriteInstance.RelativeX = 0f;
            }
            if (AimSpriteInstance.Parent == null)
            {
                base.AimSpriteInstance.Y = 78f;
            }
            else
            {
                base.AimSpriteInstance.RelativeY = 78f;
            }
            if (AimSpriteInstance.Parent == null)
            {
                base.AimSpriteInstance.Z = 1f;
            }
            else
            {
                base.AimSpriteInstance.RelativeZ = 1f;
            }
            base.AimSpriteInstance.Texture = AllParticles;
            base.AimSpriteInstance.LeftTexturePixel = 1939f;
            base.AimSpriteInstance.RightTexturePixel = 1986f;
            base.AimSpriteInstance.TopTexturePixel = 1846f;
            base.AimSpriteInstance.BottomTexturePixel = 2002f;
            base.AimSpriteInstance.TextureScale = 1f;
            if (PivotPoint.Parent == null)
            {
                PivotPoint.CopyAbsoluteToRelative();
                PivotPoint.AttachTo(this, false);
            }
            if (PivotPoint.Parent == null)
            {
                base.PivotPoint.Y = 30f;
            }
            else
            {
                base.PivotPoint.RelativeY = 30f;
            }
            if (LightAimSpriteInstance.Parent == null)
            {
                LightAimSpriteInstance.CopyAbsoluteToRelative();
                LightAimSpriteInstance.AttachTo(this, false);
            }
            if (LightAimSpriteInstance.Parent == null)
            {
                base.LightAimSpriteInstance.Y = 120f;
            }
            else
            {
                base.LightAimSpriteInstance.RelativeY = 120f;
            }
            base.LightAimSpriteInstance.Texture = AllParticles;
            base.LightAimSpriteInstance.LeftTexturePixel = 1060f;
            base.LightAimSpriteInstance.RightTexturePixel = 1122f;
            base.LightAimSpriteInstance.TopTexturePixel = 1269f;
            base.LightAimSpriteInstance.BottomTexturePixel = 1339f;
            base.LightAimSpriteInstance.TextureScale = 1f;
            base.LightAimSpriteInstance.Width = 91f;
            base.LightAimSpriteInstance.Height = 70f;
            base.LightAimSpriteInstance.Visible = true;
            #if FRB_MDX
            LightAimSpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.LightAimSpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.LightAimSpriteInstance.Red = 0.5f;
            base.LightAimSpriteInstance.Green = 0.23f;
            base.LightAimSpriteInstance.BlendOperation = FlatRedBall.Graphics.BlendOperation.Add;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            base.AddToManagersBottomUp(layerToAddTo);
        }
        public override void RemoveFromManagers () 
        {
            base.RemoveFromManagers();
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            if (AxisAlignedRectangleInstance != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(AxisAlignedRectangleInstance);
            }
            if (LightSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(LightSpriteInstance);
            }
            if (AimSpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(AimSpriteInstance);
            }
            if (PivotPoint != null)
            {
                FlatRedBall.SpriteManager.ConvertToManuallyUpdated(PivotPoint);
            }
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
            }
            base.SpriteInstance.Texture = AllParticles;
            base.SpriteInstance.LeftTexturePixel = 1949f;
            base.SpriteInstance.RightTexturePixel = 2037f;
            base.SpriteInstance.TopTexturePixel = 1724f;
            base.SpriteInstance.BottomTexturePixel = 1825f;
            base.SpriteInstance.TextureScale = 1f;
            base.SpriteInstance.UseAnimationRelativePosition = false;
            base.SpriteInstance.AnimationChains = BaseStructureAnimationChainListFile;
            base.SpriteInstance.CurrentChainName = "BombardingTower";
            base.AxisAlignedRectangleInstance.Width = 64f;
            base.AxisAlignedRectangleInstance.Height = 64f;
            if (LightSpriteInstance.Parent == null)
            {
                base.LightSpriteInstance.X = 0f;
            }
            else
            {
                base.LightSpriteInstance.RelativeX = 0f;
            }
            if (LightSpriteInstance.Parent == null)
            {
                base.LightSpriteInstance.Y = 30f;
            }
            else
            {
                base.LightSpriteInstance.RelativeY = 30f;
            }
            if (LightSpriteInstance.Parent == null)
            {
                base.LightSpriteInstance.Z = -1f;
            }
            else
            {
                base.LightSpriteInstance.RelativeZ = -1f;
            }
            base.LightSpriteInstance.LeftTexturePixel = 1792f;
            base.LightSpriteInstance.RightTexturePixel = 2048f;
            base.LightSpriteInstance.TopTexturePixel = 1792f;
            base.LightSpriteInstance.BottomTexturePixel = 2048f;
            base.LightSpriteInstance.TextureScale = 1f;
            #if FRB_MDX
            LightSpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.LightSpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.LightSpriteInstance.Blue = 0.5f;
            base.LightSpriteInstance.Alpha = 0.25f;
            if (AimSpriteInstance.Parent == null)
            {
                base.AimSpriteInstance.X = 0f;
            }
            else
            {
                base.AimSpriteInstance.RelativeX = 0f;
            }
            if (AimSpriteInstance.Parent == null)
            {
                base.AimSpriteInstance.Y = 78f;
            }
            else
            {
                base.AimSpriteInstance.RelativeY = 78f;
            }
            if (AimSpriteInstance.Parent == null)
            {
                base.AimSpriteInstance.Z = 1f;
            }
            else
            {
                base.AimSpriteInstance.RelativeZ = 1f;
            }
            base.AimSpriteInstance.Texture = AllParticles;
            base.AimSpriteInstance.LeftTexturePixel = 1939f;
            base.AimSpriteInstance.RightTexturePixel = 1986f;
            base.AimSpriteInstance.TopTexturePixel = 1846f;
            base.AimSpriteInstance.BottomTexturePixel = 2002f;
            base.AimSpriteInstance.TextureScale = 1f;
            if (PivotPoint.Parent == null)
            {
                base.PivotPoint.Y = 30f;
            }
            else
            {
                base.PivotPoint.RelativeY = 30f;
            }
            if (LightAimSpriteInstance.Parent == null)
            {
                base.LightAimSpriteInstance.Y = 120f;
            }
            else
            {
                base.LightAimSpriteInstance.RelativeY = 120f;
            }
            base.LightAimSpriteInstance.Texture = AllParticles;
            base.LightAimSpriteInstance.LeftTexturePixel = 1060f;
            base.LightAimSpriteInstance.RightTexturePixel = 1122f;
            base.LightAimSpriteInstance.TopTexturePixel = 1269f;
            base.LightAimSpriteInstance.BottomTexturePixel = 1339f;
            base.LightAimSpriteInstance.TextureScale = 1f;
            base.LightAimSpriteInstance.Width = 91f;
            base.LightAimSpriteInstance.Height = 70f;
            base.LightAimSpriteInstance.Visible = true;
            #if FRB_MDX
            LightAimSpriteInstance.ColorOperation = Microsoft.DirectX.Direct3D.TextureOperation.Modulate;
            #else
            base.LightAimSpriteInstance.ColorOperation = FlatRedBall.Graphics.ColorOperation.Modulate;
            #endif
            base.LightAimSpriteInstance.Red = 0.5f;
            base.LightAimSpriteInstance.Green = 0.23f;
            base.LightAimSpriteInstance.BlendOperation = FlatRedBall.Graphics.BlendOperation.Add;
            DisplayName = "Cannon";
            HasLightSource = false;
            ProjectileSpeed = 800f;
            RangedRadius = 850f;
            AttackDamage = 40f;
            SecondsBetweenFiring = 6;
            ProjectileAltitude = 100f;
            HasSplashDamage = true;
            MinimumRangeRadius = 450f;
            StatusEffectSeconds = 0;
            StatusDamageMultiplier = 0f;
            SatoshiCost = 20;
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(SpriteInstance);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(LightSpriteInstance);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(AimSpriteInstance);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(PivotPoint);
        }
        public static new void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            ContentManagerName = contentManagerName;
            AbbatoirIntergrade.Entities.BaseEntities.BaseStructure.LoadStaticContent(contentManagerName);
            // Set the content manager for Gum
            var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
            contentManagerWrapper.ContentManagerName = contentManagerName;
            RenderingLibrary.Content.LoaderManager.Self.ContentLoader = contentManagerWrapper;
            // Access the GumProject just in case it's async loaded
            var throwaway = GlobalContent.GumProject;
            #if DEBUG
            if (contentManagerName == FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                HasBeenLoadedWithGlobalContentManager = true;
            }
            else if (HasBeenLoadedWithGlobalContentManager)
            {
                throw new System.Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            bool registerUnload = false;
            if (LoadedContentManagers.Contains(contentManagerName) == false)
            {
                LoadedContentManagers.Add(contentManagerName);
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("BombardingTowerStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                CannonShot1 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/structures/bombardingtower/cannonshot1", ContentManagerName);
                CannonShot2 = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/entities/structures/bombardingtower/cannonshot2", ContentManagerName);
            }
            if (registerUnload && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("BombardingTowerStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
            }
            CustomLoadStaticContent(contentManagerName);
        }
        public static new void UnloadStaticContent () 
        {
            if (LoadedContentManagers.Count != 0)
            {
                LoadedContentManagers.RemoveAt(0);
                mRegisteredUnloads.RemoveAt(0);
            }
            if (LoadedContentManagers.Count == 0)
            {
                if (CannonShot1 != null)
                {
                    CannonShot1= null;
                }
                if (CannonShot2 != null)
                {
                    CannonShot2= null;
                }
            }
        }
        [System.Obsolete("Use GetFile instead")]
        public static new object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "CannonShot1":
                    return CannonShot1;
                case  "CannonShot2":
                    return CannonShot2;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "CannonShot1":
                    return CannonShot1;
                case  "CannonShot2":
                    return CannonShot2;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "CannonShot1":
                    return CannonShot1;
                case  "CannonShot2":
                    return CannonShot2;
            }
            return null;
        }
        public override bool HasCursorOver (FlatRedBall.Gui.Cursor cursor) 
        {
            if (base.HasCursorOver(cursor))
            {
                return true;
            }
            if (mIsPaused)
            {
                return false;
            }
            if (!AbsoluteVisible)
            {
                return false;
            }
            if (LayerProvidedByContainer != null && LayerProvidedByContainer.Visible == false)
            {
                return false;
            }
            if (!cursor.IsOn(LayerProvidedByContainer))
            {
                return false;
            }
            if (SpriteInstance.Alpha != 0 && SpriteInstance.AbsoluteVisible && cursor.IsOn3D(SpriteInstance, LayerProvidedByContainer))
            {
                return true;
            }
            if (LightSpriteInstance.Alpha != 0 && LightSpriteInstance.AbsoluteVisible && cursor.IsOn3D(LightSpriteInstance, LayerProvidedByContainer))
            {
                return true;
            }
            if (AimSpriteInstance.Alpha != 0 && AimSpriteInstance.AbsoluteVisible && cursor.IsOn3D(AimSpriteInstance, LayerProvidedByContainer))
            {
                return true;
            }
            if (LightAimSpriteInstance.Alpha != 0 && LightAimSpriteInstance.AbsoluteVisible && cursor.IsOn3D(LightAimSpriteInstance, LayerProvidedByContainer))
            {
                return true;
            }
            return false;
        }
        public override bool WasClickedThisFrame (FlatRedBall.Gui.Cursor cursor) 
        {
            return cursor.PrimaryClick && HasCursorOver(cursor);
        }
        public override void SetToIgnorePausing () 
        {
            base.SetToIgnorePausing();
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SpriteInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(AxisAlignedRectangleInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(LightSpriteInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(AimSpriteInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(LightAimSpriteInstance);
        }
        public override void MoveToLayer (FlatRedBall.Graphics.Layer layerToMoveTo) 
        {
            var layerToRemoveFrom = LayerProvidedByContainer; // assign before calling base so removal is not impacted by base call
            base.MoveToLayer(layerToMoveTo);
        }
    }
    public static class BombardingTowerExtensionMethods
    {
        public static void SetVisible (this FlatRedBall.Math.PositionedObjectList<BombardingTower> list, bool value) 
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                list[i].Visible = value;
            }
        }
    }
}
