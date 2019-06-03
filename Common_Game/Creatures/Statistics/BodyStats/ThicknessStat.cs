using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Creatures.Statistics
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
            // TODO: ThicknessStat: Figure out what the actual restrictions and defaults are.
            // Assuming 0..100 here based on usage in original.
            // TODO: Rework bodytype and hipdescription in original to account for waist separately.
            /* TODO: "Thickness" may need to be split up into thickness, butt, waist, hips.  Really 
             *       might just want to rework this whole mechanic to have stats for:
             *       * shoulder width
             *       * waist size (relative to hips or absolute?)
             *       * hip width
             *       * butt size
             */
            Value = 50;
            LowerBound = new IntLowerBound(maximum: 0);
            UpperBound = new IntUpperBound(this, value: 100, minimum: 100, maximum: 100);
        }
    }
}
