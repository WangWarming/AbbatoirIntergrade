﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall.Graphics;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Factories;
using AbbatoirIntergrade.GameClasses.Interfaces;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.StaticManagers;
using FlatRedBall;

namespace AbbatoirIntergrade.GameClasses.BaseClasses
{
    public abstract class BaseLevel
    {
        public abstract string MapName { get; }
        public abstract DateTime StartTime { get; }
        public abstract List<BaseWave> Waves { get; }
        private List<BaseWave> _waves;
        public int CurrentWaveNumber { get; private set; } = 0;

        public virtual int StartingLives { get; } = 1;

        protected double SecondsBetweenWaves = 0;

        private List<EnemyTypes> _availableEnemyTypes;

        public virtual List<EnemyTypes> AvailableEnemyTypes
        {
            get
            {
                if (_availableEnemyTypes == null)
                {
                    _availableEnemyTypes = Waves.SelectMany(w => w.EnemyTypes).Distinct().ToList();
                }
                return _availableEnemyTypes;
            }
        }

        public int RemainingLives { get; set; }

        public EventHandler OnNewWaveStart;

        private double _lastEnemyWave = 0;

        protected FlatRedBall.Math.PositionedObjectList<BaseEnemy> _enemyList;

        protected BaseLevel()
        {
            _lastEnemyWave = 0;
            RemainingLives = StartingLives;
        }

        public void SetEnemiesAndLayer(FlatRedBall.Math.PositionedObjectList<BaseEnemy> enemyList)
        {
            _enemyList = enemyList;
        }
        
        public bool HasReachedDefeat()
        {
            return RemainingLives <= 0;
        }

        private void CreateEnemiesForWave()
        {
            if (CurrentWaveNumber < Waves.Count)
            {
                Waves[CurrentWaveNumber].CreateEnemies();
            }
            else
            {
                GenerateWave().CreateEnemies();
            }
            CurrentWaveNumber++;
            _lastEnemyWave = TimeManager.CurrentTime;
            OnNewWaveStart?.Invoke(this, null);
        }

        public void Update()
        {
            if (_lastEnemyWave == 0)
            {
                CreateEnemiesForWave();
            }
            else if (TimeManager.SecondsSince(_lastEnemyWave) >= SecondsBetweenWaves && _enemyList.Count == 0)
            {
                CreateEnemiesForWave();
            }
        }

        private BaseWave GenerateWave()
        {
            //TODO:  AI generates wave using point system
            var pointsAvailable = Waves.Last().PointValue + (CurrentWaveNumber - Waves.Count);
            var enemiesInWave = new List<Tuple<int, EnemyTypes>>();

            return new BaseWave(enemiesInWave);
        }
    }
}
