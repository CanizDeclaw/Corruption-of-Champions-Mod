﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    // You can use an instance of this class directly as a readonly decimal.
    public class DecimalValue
    {
        protected virtual bool NoNegatives { get; }
        protected virtual decimal BaseValue { get; set; }

        protected virtual decimal FindBaseValue(decimal value)
        {
            if (NoNegatives && value < 0)
            {
                value = 0;
            }
            return value - StaticModifiers.Values.Sum();
        }

        /// <summary>
        /// Returns the sum of BaseValue and all StaticModifiers.
        /// 
        /// On setting, BaseValue is set to the difference between the input value
        /// and all StaticModifiers, such that the output value is equal to the input value.
        /// </summary>
        public virtual decimal Value
        {
            get
            {
                var value = BaseValue + StaticModifiers.Values.Sum();
                if (NoNegatives && value < 0)
                {
                    value = 0;
                    Value = value;
                }
                return value;
            }
            protected set
            {
                BaseValue = FindBaseValue(value);
            }
        }
        /// <summary>
        /// Adds the sum of relativeAdjustment and all OnAdjusting delegates
        /// to BaseValue.
        /// </summary>
        /// <param name="relativeAdjustment">The amount to adjust the value by.</param>
        public virtual void AdjustValue(decimal relativeAdjustment)
        {
            // Decimal values used to allow easy percentage modifications.
            var mods = OnAdjusting.Values.Sum(oa => oa(relativeAdjustment));
            var value = BaseValue + relativeAdjustment + mods;
            BaseValue = FindBaseValue(value);
        }
        public virtual decimal Set(decimal value) => Value = value;

        public static implicit operator decimal(DecimalValue iv)
        {
            return iv.Value;
        }

        /// <summary>
        /// StaticModifiers are summed and added to the underlying value
        /// for output.
        /// </summary>
        public Dictionary<string, decimal> StaticModifiers;

        /// <summary>
        /// When adjustments (adding or subtracting a value) are made to this,
        /// these are summed and added to the adjustment before setting the new
        /// value.
        /// </summary>
        public Dictionary<string, AdjustmentModifier> OnAdjusting;

        public DecimalValue(decimal initialValue = 0, bool noNegatives = false)
        {
            NoNegatives = noNegatives;
            StaticModifiers = new Dictionary<string, decimal>();
            OnAdjusting = new Dictionary<string, AdjustmentModifier>();
            Value = initialValue;
        }
    }
}
