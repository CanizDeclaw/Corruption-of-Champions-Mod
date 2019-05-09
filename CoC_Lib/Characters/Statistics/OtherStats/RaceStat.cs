using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters.Statistics
{
    public class RaceStat : StringStatistic
    {
        private readonly Creature Creature;

        public override string Name => "Race";
        public override string Description => "Your race.";
        public override string Value => Creature.RaceString;

        public RaceStat(Creature creature)
        {
            Creature = creature;
        }
    }
}
