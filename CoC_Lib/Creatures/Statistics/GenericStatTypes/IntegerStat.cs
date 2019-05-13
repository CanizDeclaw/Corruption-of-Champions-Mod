using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public abstract class IntegerStat : ScalarStatistic
    {
        protected virtual int BaseValue { get; set; }
        public virtual int Value
        {
            get => BaseValue + (int)ValueModifiers.Values.Sum(vm => vm(BaseValue));
        }
        // Why?  Think about `SomeStat.Value += 2` when `SomeStat` has modifiers.
        public virtual void AdjustBaseValue(int relativeAdjustment)
        {
            // Decimal values used to allow easy percentage modifications.
            decimal modifier = 0;
            foreach (var modFunction in OnBaseValueAdjusting.Values)
            {
                // TODO: Originally cumulative adjustments.  I've changed it here so
                //       that each works on the base adjustment alone.
                modifier += modFunction(relativeAdjustment);
            }
            BaseValue += relativeAdjustment + (int)modifier;
        }
        public virtual void SetBaseValue(int value)
        {
            BaseValue = value;
        }

        /// <summary>
        /// Delegate for modifying the output value.
        /// </summary>
        /// <param name="value">The base value.</param>
        /// <returns>The amount to adjust the value.</returns>
        public delegate decimal ValueModifier(decimal value);
        public Dictionary<object, ValueModifier> ValueModifiers;

        /// <summary>
        /// Delegate for modifying incoming adjustments.
        /// </summary>
        /// <param name="value">The base adjustment value.</param>
        /// <returns>The amount to adjust the adjustment value.</returns>
        public delegate decimal BaseValueAdjustmentModifier(decimal value);
        public Dictionary<object, BaseValueAdjustmentModifier> OnBaseValueAdjusting;

        public IntegerStat(Creature creature)
            :base(creature)
        {
            ValueModifiers = new Dictionary<object, ValueModifier>();
            OnBaseValueAdjusting = new Dictionary<object, BaseValueAdjustmentModifier>();
        }
    }
}
