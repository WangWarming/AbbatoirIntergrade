using AbbatoirIntergrade.Entities.Projectiles;
using System;
using AbbatoirIntergrade.Entities.BaseEntities;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
using AbbatoirIntergrade.Performance;

namespace AbbatoirIntergrade.Factories
{
    public class PiercingProjectileFactory : IEntityFactory
    {
        public static FlatRedBall.Math.Axis? SortAxis { get; set;}
        public static PiercingProjectile CreateNew (float x = 0, float y = 0) 
        {
            return CreateNew(null, x, y);
        }
        public static PiercingProjectile CreateNew (Layer layer, float x = 0, float y = 0) 
        {
            if (string.IsNullOrEmpty(mContentManagerName))
            {
                throw new System.Exception("You must first initialize the factory to use it. You can either add PositionedObjectList of type PiercingProjectile (the most common solution) or call Initialize in custom code");
            }
            PiercingProjectile instance = null;
            instance = new PiercingProjectile(mContentManagerName, false);
            instance.AddToManagers(layer);
            instance.X = x;
            instance.Y = y;
            foreach (var list in ListsToAddTo)
            {
                if (SortAxis == FlatRedBall.Math.Axis.X && list is PositionedObjectList<PiercingProjectile>)
                {
                    var index = (list as PositionedObjectList<PiercingProjectile>).GetFirstAfter(x, Axis.X, 0, list.Count);
                    list.Insert(index, instance);
                }
                else if (SortAxis == FlatRedBall.Math.Axis.Y && list is PositionedObjectList<PiercingProjectile>)
                {
                    var index = (list as PositionedObjectList<PiercingProjectile>).GetFirstAfter(y, Axis.Y, 0, list.Count);
                    list.Insert(index, instance);
                }
                else
                {
                    // Sort Z not supported
                    list.Add(instance);
                }
            }
            if (EntitySpawned != null)
            {
                EntitySpawned(instance);
            }
            return instance;
        }
        
        public static void Initialize (string contentManager) 
        {
            mContentManagerName = contentManager;
        }
        
        public static void Destroy () 
        {
            mContentManagerName = null;
            ListsToAddTo.Clear();
            SortAxis = null;
            mPool.Clear();
            EntitySpawned = null;
        }
        
        private static void FactoryInitialize () 
        {
            const int numberToPreAllocate = 20;
            for (int i = 0; i < numberToPreAllocate; i++)
            {
                PiercingProjectile instance = new PiercingProjectile(mContentManagerName, false);
                mPool.AddToPool(instance);
            }
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (PiercingProjectile objectToMakeUnused) 
        {
            MakeUnused(objectToMakeUnused, true);
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (PiercingProjectile objectToMakeUnused, bool callDestroy) 
        {
            if (callDestroy)
            {
                objectToMakeUnused.Destroy();
            }
        }
        
        public static void AddList<T> (System.Collections.Generic.IList<T> newList) where T : Entities.BaseEntities.BasePlayerProjectile
        {
            ListsToAddTo.Add(newList as System.Collections.IList);
        }
        public static void RemoveList<T> (System.Collections.Generic.IList<T> newList) where T : Entities.BaseEntities.BasePlayerProjectile
        {
            ListsToAddTo.Remove(newList as System.Collections.IList);
        }
        public static void ClearListsToAddTo () 
        {
            ListsToAddTo.Clear();
        }
        
        
            static string mContentManagerName;
            static System.Collections.Generic.List<System.Collections.IList> ListsToAddTo = new System.Collections.Generic.List<System.Collections.IList>();
            static PoolList<PiercingProjectile> mPool = new PoolList<PiercingProjectile>();
            public static Action<PiercingProjectile> EntitySpawned;
            object IEntityFactory.CreateNew () 
            {
                return PiercingProjectileFactory.CreateNew();
            }
            object IEntityFactory.CreateNew (Layer layer) 
            {
                return PiercingProjectileFactory.CreateNew(layer);
            }
            void IEntityFactory.Initialize (string contentManagerName) 
            {
                PiercingProjectileFactory.Initialize(contentManagerName);
            }
            void IEntityFactory.ClearListsToAddTo () 
            {
                PiercingProjectileFactory.ClearListsToAddTo();
            }
            static PiercingProjectileFactory mSelf;
            public static PiercingProjectileFactory Self
            {
                get
                {
                    if (mSelf == null)
                    {
                        mSelf = new PiercingProjectileFactory();
                    }
                    return mSelf;
                }
            }
    }
}