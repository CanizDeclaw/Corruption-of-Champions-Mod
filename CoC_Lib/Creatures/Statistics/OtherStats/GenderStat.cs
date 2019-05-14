using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class GenderStat : StringStatistic
    {
        public override string Name => "Gender";
        public override string Description => "Your gender.";
        public override string Value => creature.GenderString;

        public GenderStat(Game game, Creature creature)
            :base(game, creature)
        { }
    }
}
