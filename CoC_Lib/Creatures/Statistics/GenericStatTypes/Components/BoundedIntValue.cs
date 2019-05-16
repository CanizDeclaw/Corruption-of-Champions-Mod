﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class BoundedIntValue : IntValue
    {
        protected virtual BoundedIntegerStat Parent
        { get; }
        protected override int BaseValue
        { get; set; }

        protected virtual int FindBaseValue(int value)
        {
            if (value > Parent.Maximum)
            {
                value = Parent.Maximum;
            }
            else if (value < Parent.Minimum)
            {
                value = Parent.Minimum;
            }
            return value - (int)StaticModifiers.Values.Sum();
        }
        /// <summary>
        /// Value is the sum of BaseValue and all modifiers, limited by the Minimum and Maximum
        /// of the enclosing BoundedIntegerStat.
        /// 
        /// On setting, the input value is restricted to fit within the boundaries of Minimum and Maximum,
        /// then BaseValue is set to the difference between the input value and all StaticModifiers, 
        /// such that the output value is equal to the input value.
        /// </summary>
        public override int Value
        {
            get
            {
                return BaseValue + (int)StaticModifiers.Values.Sum();
            }
            set
            {
                BaseValue = FindBaseValue(value);
            }
        }
        /// <summary>
        /// Adds the sum of relativeAdjustment and all OnAdjusting delegates
        /// to BaseValue.
        /// 
        /// If Value would exceed Minimum or Maximum, BaseValue is adjusted so it fits.
        /// </summary>
        /// <param name="relativeAdjustment">The amount to adjust the value by.</param>
        protected override void AdjustValue(int relativeAdjustment)
        {
            // Decimal values used to allow easy percentage modifications.
            decimal modifier = 0;
            foreach (var modFunction in OnAdjusting.Values)
            {
                modifier += modFunction(relativeAdjustment);
            }
            var value = Value + relativeAdjustment + (int)modifier;
            BaseValue = FindBaseValue(value);
        }

        public static implicit operator int(BoundedIntValue iv)
        {
            return iv.Value;
        }

        public BoundedIntValue(BoundedIntegerStat parent, int initialValue)
        {
            Parent = parent;
            BaseValue = initialValue;
        }
    }
}
