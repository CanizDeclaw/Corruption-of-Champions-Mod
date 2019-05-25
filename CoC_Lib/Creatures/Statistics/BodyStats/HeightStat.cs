using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class HeightStat : BoundedIntegerStat
    {
        public override string Name => "Height";
        public override string Description => "Height in inches."; // TODO: Standardize descriptions.

        public HeightStat(Game game, Creature creature)
            : base(game, creature)
        {
            // TODO: HeightStat: Figure out what the actual restrictions and defaults are.
            Value = 52;
            LowerBound = new IntLowerBound(value: 1, minimum: 1);
            UpperBound = new IntUpperBound(this, minimum: 1);
        }
    }
}
