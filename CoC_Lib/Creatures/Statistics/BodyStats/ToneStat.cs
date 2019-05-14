using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class ToneStat : IntegerStat
    {
        public override string Name => "Tone";
        public override string Description => ""; // TODO: Finish writing stat.

        public ToneStat(Game game, Creature creature)
            :base(game, creature)
        {
            SetBaseValue(0); // TODO: Figure out actual default.
        }
    }
}
