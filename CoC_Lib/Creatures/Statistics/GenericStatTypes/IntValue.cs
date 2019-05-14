using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    // You can use an instance of this class directly as a readonly int.  Setting should 
    // be done through `Set(int)`.
    public class IntValue
    {
        protected virtual int BaseValue { get; set; }
        protected virtual void AdjustBaseValue(int relativeAdjustment)
        {
            // Decimal values used to allow easy percentage modifications.
            decimal modifier = 0;
            foreach (var modFunction in OnAdjusting.Values)
            {
                // TODO: Originally cumulative adjustments.  I've changed it here so
                //       that each works on the base adjustment alone.
                modifier += modFunction(relativeAdjustment);
            }
            BaseValue += relativeAdjustment + (int)modifier;
        }
        public virtual int Get() => Value;
        public virtual int Set(int value) => BaseValue = value;
        public virtual int Value
        {
            get
            {
                return BaseValue + (int)Modifiers.Values.Sum(vm => vm(BaseValue));
            }
            set
            {
                BaseValue = value;
            }
        }
        public static implicit operator int(IntValue iv)
        {
            return iv.Value;
        }
        public static implicit operator IntValue(int i)
        {
            var iv = new IntValue();
            iv.BaseValue = i;
            return iv;
        }

        /// <summary>
        /// Delegate for modifying the output value.
        /// </summary>
        /// <param name="value">The base value.</param>
        /// <returns>The amount to adjust the value.</returns>
        public delegate decimal ValueModifier(decimal value);
        /// <summary>
        /// Modifiers are summed and added to the underlying value
        /// for output.
        /// </summary>
        public Dictionary<object, ValueModifier> Modifiers;

        /// <summary>
        /// Delegate for modifying incoming adjustments.
        /// </summary>
        /// <param name="value">The base adjustment value.</param>
        /// <returns>The amount to adjust the adjustment value.</returns>
        public delegate decimal BaseValueAdjustmentModifier(decimal value);
        /// <summary>
        /// When adjustments (adding or subtracting a value) are made to this,
        /// these are summed and added to the adjustment before setting the new
        /// value.
        /// </summary>
        public Dictionary<object, BaseValueAdjustmentModifier> OnAdjusting;

        public IntValue()
        {
            Modifiers = new Dictionary<object, ValueModifier>();
            OnAdjusting = new Dictionary<object, BaseValueAdjustmentModifier>();
        }
    }
}
