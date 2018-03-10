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
        public override int StartingLives => 20;
        public override HorizonBoxRuntime.Scenery Scenery => HorizonBoxRuntime.Scenery.SparseTrees;
        public override List<string> SongNameList => new List<string>() {nameof(GlobalContent.anttisinstrumentals_badmorning), nameof(GlobalContent.anttisinstrumentals_woman), nameof(GlobalContent.anttisinstrumentals_sidish) };

        public override List<BaseWave> Waves => new List<BaseWave>() { 
            new BaseWave(new EnemyList(EnemyTypes.Chicken1, 2)),
            new BaseWave(new EnemyList(EnemyTypes.Chicken1, 5)),
            new BaseWave(new EnemyList(EnemyTypes.Rabbit1, 8)),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Rabbit1),
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Chicken1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(8, EnemyTypes.Sheep1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Rabbit1),
                SerializableTuple<int, EnemyTypes>.Create(10, EnemyTypes.Sheep1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(12, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Rabbit1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(14, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Rabbit1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(7, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(16, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(7, EnemyTypes.Rabbit1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(20, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Rabbit1)
            }),
        };
    }
}
