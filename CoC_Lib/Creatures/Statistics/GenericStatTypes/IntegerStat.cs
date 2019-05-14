using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public abstract class IntegerStat : ScalarStatistic
    {
        public virtual IntValue Value { get; }

        public IntegerStat(Game game, Creature creature)
            :base(game, creature)
        {
            Value = 0;
        }

        public IntegerStat(Game game, Creature creature, int startingValue)
            : base(game, creature)
        {
            Value = startingValue;
        }
    }
}
