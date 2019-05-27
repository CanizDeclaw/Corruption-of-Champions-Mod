using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public abstract class DecimalStat : ScalarStatistic
    {
        public virtual DecimalValue Value { get; protected set; }

        // Convenience methods, all implemented through Value.
        public virtual void Adjust(decimal adjustment) => Value.AdjustValue(adjustment);
        public virtual void Adjust(DynamicModifier adjustment) => Value.AdjustValue((decimal)adjustment(Value));
        public virtual void Increase(decimal increase) => Value.AdjustValue(increase);
        public virtual void Increase(DynamicModifier increase) => Value.AdjustValue((decimal)increase(Value));
        public virtual void Decrease(decimal decrease) => Value.AdjustValue(-decrease);
        public virtual void Decrease(DynamicModifier decrease) => Value.AdjustValue(-(decimal)decrease(Value));
        public virtual decimal Set(decimal value) => Value.Set(value);
        public static implicit operator decimal(DecimalStat stat) => stat.Value;

        public DecimalStat(Game game, Creature creature)
            :base(game, creature)
        {
            Value = new DecimalValue();
        }
    }
}
