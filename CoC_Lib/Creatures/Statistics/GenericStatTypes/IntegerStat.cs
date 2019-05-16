using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public abstract class IntegerStat : ScalarStatistic
    {
        public abstract IntValue Value { get; protected set; }

        public IntegerStat(Game game, Creature creature)
            :base(game, creature)
        {
        }
    }
}
