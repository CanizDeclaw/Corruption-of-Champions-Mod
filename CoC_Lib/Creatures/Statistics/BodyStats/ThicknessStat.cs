using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    // TODO: Figure out actual stat type.
    public class ThicknessStat : IntegerStat
    {
        public override string Name => "Thickness";
        public override string Description => "Used for hip rating."; // TODO: Standardize descriptions.
        // TODO: Rename?
        // TODO: Fix description.

        public ThicknessStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(52);
        }
    }
}
