﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.UtilityClasses;

namespace AbbatoirIntergrade.GameClasses.Levels
{
    class Chapter4Level : BaseLevel
    {
        public override string MapName => "Chapter4";
        public override DateTime StartTime => new DateTime(2017, 10, 24, 18, 0, 0);
        public override int StartingLives => 30;
        public override HorizonBoxRuntime.Scenery Scenery => HorizonBoxRuntime.Scenery.ForestedHills;
        public override List<string> SongNameList => new List<string>() { nameof(GlobalContent.anttisinstrumentals_crocketttubbs), nameof(GlobalContent.anttisinstrumentals_enoughexcitementforalifetime), nameof(GlobalContent.anttisinstrumentals_fiveminutesofwhy) };

        public override List<BaseWave> Waves => new List<BaseWave>() {
            new BaseWave(new EnemyList(EnemyTypes.Pig1)
            ),
            new BaseWave(new EnemyList(EnemyTypes.Sheep1, 3)),
            new BaseWave(new EnemyList(EnemyTypes.Rabbit1, 5)),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(1, EnemyTypes.Pig1),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Chicken2)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Chicken2),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Sheep1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(6, EnemyTypes.Chicken2),
                SerializableTuple<int, EnemyTypes>.Create(1, EnemyTypes.Cow2)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(6, EnemyTypes.Chicken2),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Cow2),
                SerializableTuple<int, EnemyTypes>.Create(1, EnemyTypes.Pig1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(6, EnemyTypes.Cow2),
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(6, EnemyTypes.Chicken2),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Rabbit1),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Cow2),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Pig1)
            }),
        };
    }
}