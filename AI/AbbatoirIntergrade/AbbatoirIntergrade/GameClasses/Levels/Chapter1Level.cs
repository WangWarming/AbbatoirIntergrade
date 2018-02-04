﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall.Graphics;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities.Enemies;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using AbbatoirIntergrade.GameClasses.Interfaces;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.UtilityClasses;

namespace AbbatoirIntergrade.GameClasses.Levels
{
    class Chapter1Level : BaseLevel
    {
        public override string MapName => "Chapter1";
        public override DateTime StartTime => new DateTime(2017, 10, 21, 6, 0, 0);
        public override int StartingLives => 30;
        public override List<string> SongNameList => new List<string>() {nameof(GlobalContent.anttisinstrumentals_badmorning), nameof(GlobalContent.anttisinstrumentals_woman)};

        public override List<BaseWave> Waves => new List<BaseWave>() { 
            new BaseWave(new EnemyList(EnemyTypes.Rabbit1)
            ),
            new BaseWave(new EnemyList(EnemyTypes.Rabbit1, 3)),
            new BaseWave(new EnemyList(EnemyTypes.Rabbit1, 5)),
            new BaseWave(new EnemyList(EnemyTypes.Rabbit1, 8)),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Rabbit1),
                SerializableTuple<int, EnemyTypes>.Create(7, EnemyTypes.Sheep1)
            }),
        };
    }
}
