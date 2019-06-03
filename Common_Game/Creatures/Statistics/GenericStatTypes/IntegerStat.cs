using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common_Game.Creatures.Statistics
{
    public abstract class IntegerStat : ScalarStatistic
    {
        public virtual IntValue Value { get; protected set; }

        // Convenience methods, all implemented through Value.
        public virtual void Adjust(int adjustment) => Value.AdjustValue(adjustment);
        public virtual void Adjust(DynamicModifier adjustment) => Value.AdjustValue((int)adjustment(Value));
        public virtual void Increase(int increase) => Value.AdjustValue(increase);
        public virtual void Increase(DynamicModifier increase) => Value.AdjustValue((int)increase(Value));
        public virtual void Decrease(int decrease) => Value.AdjustValue(-decrease);
        public virtual void Decrease(DynamicModifier decrease) => Value.AdjustValue(-(int)decrease(Value));
        public virtual int Set(int value) => Value.Set(value);
        public static implicit operator int(IntegerStat stat) => stat.Value;

        public IntegerStat(Game game, Creature creature)
            :base(game, creature)
        {
            Value = new IntValue();
        }
    }
}
