using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    // TODO: GenderStat
    // TODO: Might need a separate SexStat
    public class GenderStat : StringStatistic
    {
        public override string Name => "Gender";
        public override string Description => "Gender";
        public override string Value => creature.GenderString;

        public GenderStat(Game game, Creature creature)
            :base(game, creature)
        { }
    }
}
