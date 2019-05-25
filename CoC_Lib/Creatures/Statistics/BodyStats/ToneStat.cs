using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class ToneStat : BoundedIntegerStat
    {
        public override string Name => "Tone";
        public override string Description => "Tone"; // TODO: Finish writing stat.

        public ToneStat(Game game, Creature creature)
            :base(game, creature)
        {
            // TODO: ThicknessStat: Figure out what the actual restrictions and defaults are.
            // Assuming 0..100 here based on usage in original.
            Value = 50;
            LowerBound = new IntLowerBound(maximum: 0);
            UpperBound = new IntUpperBound(this, value: 100, minimum: 100, maximum: 100);
        }
    }
}
