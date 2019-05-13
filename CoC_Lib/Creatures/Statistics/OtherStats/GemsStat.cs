using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class GemsStat : IntegerStat
    {
        public override string Name => "Gems";
        public override string Description => "";

        public GemsStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(0);
        }
    }
}
