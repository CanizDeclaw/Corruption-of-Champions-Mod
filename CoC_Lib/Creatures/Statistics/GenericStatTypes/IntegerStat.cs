using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public abstract class IntegerStat : ScalarStatistic
    {
        public virtual IntValue Value { get; protected set; }

        // Convenience methods, all implemented through Value.
        public virtual void Adjust(int adjustment) => Value.AdjustValue(adjustment);
        public virtual void Increase(int increase) => Value.AdjustValue(increase);
        public virtual void Decrease(int decrease) => Value.AdjustValue(-decrease);
        public virtual int Set(int value) => Value.Set(value);
        public static implicit operator int(IntegerStat stat) => stat.Value;

        public IntegerStat(Game game, Creature creature)
            :base(game, creature)
        {
            Value = new IntValue();
        }
    }
}
