using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class HeightStat : BoundedIntegerStat
    {
        public override string Name => "Height";
        public override string Description => "Your height, in inches."; // TODO: Standardize descriptions.

        public HeightStat(Creature creature)
            : base(creature)
        {
            // TODO: Implement mutable minimum
            // TODO: Figure out what the actual restrictions and defaults are.
            SetBaseValue(52);
            SetBaseMaximum(100);
        }
    }
}
