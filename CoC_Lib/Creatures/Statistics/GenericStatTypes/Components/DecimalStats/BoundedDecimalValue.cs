using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class BoundedDecimalValue : DecimalValue
    {
        protected virtual BoundedDecimalStat Parent { get; }
        protected override decimal BaseValue { get; set; }
        protected virtual bool CanOverflow { get; }
        protected bool NoOverflow => !CanOverflow;

        protected override decimal FindBaseValue(decimal value)
        {
            if (NoOverflow && value > Parent.Maximum)
            {
                value = Parent.Maximum;
            }
            else if (value < Parent.Minimum)
            {
                value = Parent.Minimum;
            }
            return value - StaticModifiers.Values.Sum();
        }
        /// <summary>
        /// Value is the sum of BaseValue and all modifiers, limited by the Minimum and Maximum
        /// of the enclosing BoundedDecimalStat.
        /// 
        /// On setting, the input value is restricted to fit within the boundaries of Minimum and Maximum,
        /// then BaseValue is set to the difference between the input value and all StaticModifiers, 
        /// such that the output value is equal to the input value.
        /// </summary>
        public override decimal Value
        {
            get
            {
                var value = BaseValue + StaticModifiers.Values.Sum();
                if (NoOverflow && value > Parent.Maximum)
                {
                    value = Parent.Maximum;
                    Value = value;
                }
                else if (value < Parent.Minimum)
                {
                    value = Parent.Minimum;
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
        /// 
        /// If Value would exceed Minimum or Maximum, BaseValue is adjusted so it fits.
        /// </summary>
        /// <param name="relativeAdjustment">The amount to adjust the value by.</param>
        public override void AdjustValue(decimal relativeAdjustment)
        {
            // Decimal values used to allow easy percentage modifications.
            var mods = OnAdjusting.Values.Sum(oa => oa(relativeAdjustment));
            var value = Value + relativeAdjustment + (decimal)mods;
            BaseValue = FindBaseValue(value);
        }

        public static implicit operator decimal(BoundedDecimalValue iv)
        {
            return iv.Value;
        }

        public BoundedDecimalValue(BoundedDecimalStat parent, decimal initialValue, bool canOverflow = false)
        {
            Parent = parent;
            BaseValue = initialValue;
            CanOverflow = canOverflow;
        }
    }
}
