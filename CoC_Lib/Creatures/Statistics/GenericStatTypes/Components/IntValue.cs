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
        /// <summary>
        /// Returns the sum of BaseValue and all StaticModifiers.
        /// 
        /// On setting, BaseValue is set to the difference between the input value
        /// and all StaticModifiers, such that the output value is equal to the input value.
        /// </summary>
        public virtual int Value
        {
            get
            {
                return BaseValue + (int)StaticModifiers.Values.Sum();
            }
            set
            {
                BaseValue = value - (int)StaticModifiers.Values.Sum();
            }
        }
        /// <summary>
        /// Adds the sum of relativeAdjustment and all OnAdjusting delegates
        /// to BaseValue.
        /// </summary>
        /// <param name="relativeAdjustment">The amount to adjust the value by.</param>
        public virtual void AdjustValue(int relativeAdjustment)
        {
            // Decimal values used to allow easy percentage modifications.
            decimal modifier = 0;
            foreach (var modFunction in OnAdjusting.Values)
            {
                modifier += modFunction(relativeAdjustment);
            }
            BaseValue += relativeAdjustment + (int)modifier;
        }
        public virtual int Get() => Value;
        public virtual int Set(int value) => Value = value;

        public static implicit operator int(IntValue iv)
        {
            return iv.Value;
        }
        public static implicit operator IntValue(int i)
        {
            var iv = new IntValue
            {
                BaseValue = i
            };
            return iv;
        }

        /// <summary>
        /// StaticModifiers are summed and added to the underlying value
        /// for output.
        /// </summary>
        public Dictionary<object, decimal> StaticModifiers;

        /// <summary>
        /// Delegate for modifying incoming adjustments.
        /// </summary>
        /// <param name="value">The base adjustment value.</param>
        /// <returns>The amount to adjust the adjustment value.</returns>
        public delegate decimal AdjustmentModifier(decimal adjustment);
        /// <summary>
        /// When adjustments (adding or subtracting a value) are made to this,
        /// these are summed and added to the adjustment before setting the new
        /// value.
        /// </summary>
        public Dictionary<object, AdjustmentModifier> OnAdjusting;

        public IntValue()
        {
            StaticModifiers = new Dictionary<object, decimal>();
            OnAdjusting = new Dictionary<object, AdjustmentModifier>();
        }
    }
}
