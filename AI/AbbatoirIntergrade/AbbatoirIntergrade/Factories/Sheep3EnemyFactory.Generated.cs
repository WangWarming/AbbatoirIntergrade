using AbbatoirIntergrade.Entities.Enemies;
using System;
using AbbatoirIntergrade.Entities.BaseEntities;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
using AbbatoirIntergrade.Performance;

namespace AbbatoirIntergrade.Factories
{
    public class Sheep3EnemyFactory : IEntityFactory
    {
        public static FlatRedBall.Math.Axis? SortAxis { get; set;}
        public static Sheep3Enemy CreateNew (float x = 0, float y = 0) 
        {
            return CreateNew(null, x, y);
        }
        public static Sheep3Enemy CreateNew (Layer layer, float x = 0, float y = 0) 
        {
            if (string.IsNullOrEmpty(mContentManagerName))
            {
                throw new System.Exception("You must first initialize the factory to use it. You can either add PositionedObjectList of type Sheep3Enemy (the most common solution) or call Initialize in custom code");
            }
            Sheep3Enemy instance = null;
            instance = mPool.GetNextAvailable();
            if (instance == null)
            {
                mPool.AddToPool(new Sheep3Enemy(mContentManagerName, false));
                instance =  mPool.GetNextAvailable();
            }
            instance.AddToManagers(layer);
            instance.X = x;
            instance.Y = y;
            foreach (var list in ListsToAddTo)
            {
                if (SortAxis == FlatRedBall.Math.Axis.X && list is PositionedObjectList<Sheep3Enemy>)
                {
                    var index = (list as PositionedObjectList<Sheep3Enemy>).GetFirstAfter(x, Axis.X, 0, list.Count);
                    list.Insert(index, instance);
                }
                else if (SortAxis == FlatRedBall.Math.Axis.Y && list is PositionedObjectList<Sheep3Enemy>)
                {
                    var index = (list as PositionedObjectList<Sheep3Enemy>).GetFirstAfter(y, Axis.Y, 0, list.Count);
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
            FactoryInitialize();
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
                Sheep3Enemy instance = new Sheep3Enemy(mContentManagerName, false);
                mPool.AddToPool(instance);
            }
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (Sheep3Enemy objectToMakeUnused) 
        {
            MakeUnused(objectToMakeUnused, true);
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (Sheep3Enemy objectToMakeUnused, bool callDestroy) 
        {
            mPool.MakeUnused(objectToMakeUnused);
            
            if (callDestroy)
            {
                objectToMakeUnused.Destroy();
            }
        }
        
        public static void AddList<T> (System.Collections.Generic.IList<T> newList) where T : Entities.BaseEntities.BaseEnemy
        {
            ListsToAddTo.Add(newList as System.Collections.IList);
        }
        public static void RemoveList<T> (System.Collections.Generic.IList<T> newList) where T : Entities.BaseEntities.BaseEnemy
        {
            ListsToAddTo.Remove(newList as System.Collections.IList);
        }
        public static void ClearListsToAddTo () 
        {
            ListsToAddTo.Clear();
        }
        
        
            static string mContentManagerName;
            static System.Collections.Generic.List<System.Collections.IList> ListsToAddTo = new System.Collections.Generic.List<System.Collections.IList>();
            static PoolList<Sheep3Enemy> mPool = new PoolList<Sheep3Enemy>();
            public static Action<Sheep3Enemy> EntitySpawned;
            object IEntityFactory.CreateNew () 
            {
                return Sheep3EnemyFactory.CreateNew();
            }
            object IEntityFactory.CreateNew (Layer layer) 
            {
                return Sheep3EnemyFactory.CreateNew(layer);
            }
            void IEntityFactory.Initialize (string contentManagerName) 
            {
                Sheep3EnemyFactory.Initialize(contentManagerName);
            }
            void IEntityFactory.ClearListsToAddTo () 
            {
                Sheep3EnemyFactory.ClearListsToAddTo();
            }
            static Sheep3EnemyFactory mSelf;
            public static Sheep3EnemyFactory Self
            {
                get
                {
                    if (mSelf == null)
                    {
                        mSelf = new Sheep3EnemyFactory();
                    }
                    return mSelf;
                }
            }
    }
}