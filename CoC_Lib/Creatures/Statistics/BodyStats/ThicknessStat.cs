using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    // TODO: Figure out actual stat type.
    public class ThicknessStat : BoundedIntegerStat
    {
        public override string Name => "Thickness";
        public override string Description => "Used for hip rating."; // TODO: Standardize descriptions.
        // TODO: Rename?
        // TODO: Fix description.

        public ThicknessStat(Game game, Creature creature)
            : base(game, creature)
        {
            Value = 52;
            LowerBound = new IntLowerBound(0);
            UpperBound = new IntUpperBound(9999);
        }
    }
}
