using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class RaceStat : StringStatistic
    {
        public override string Name => "Race";
        public override string Description => "Your race.";
        public override string Value => creature.RaceString;

        public RaceStat(Game game, Creature creature)
            : base(game, creature)
        { }
    }
}
