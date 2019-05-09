using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters.Statistics
{
    public class GenderStat : StringStatistic
    {
        private readonly Creature Creature;

        public override string Name => "Gender";
        public override string Description => "Your gender.";
        public override string Value => Creature.GenderString;

        public GenderStat(Creature creature)
        {
            Creature = creature;
        }
    }
}
