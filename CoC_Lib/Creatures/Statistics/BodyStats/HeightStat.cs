using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class HeightStat : BoundedIntegerStat
    {
        public override string Name => "Height";
        public override string Description => "Your height, in inches."; // TODO: Standardize descriptions.

        public HeightStat(Game game, Creature creature)
            : base(game, creature)
        {
            // TODO: Figure out what the actual restrictions and defaults are.
            Value = 52;
            LowerBound = new IntLowerBound(0);
        }
    }
}
