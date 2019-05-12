using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters.Statistics
{
    public class GenderStat : StringStatistic
    {
        public override string Name => "Gender";
        public override string Description => "Your gender.";
        public override string Value => creature.GenderString;

        public GenderStat(Creature creature)
            :base(creature)
        { }
    }
}
