using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common_Game.Creatures.Statistics
{
    public class DecimalUpperBound
    {
        protected virtual BoundedDecimalStat Parent { get; }
        protected virtual decimal BaseValue { get; set; }
        public virtual decimal Minimum { get; }
        public virtual decimal Maximum { get; }
        public virtual decimal Value
        {
            get
            {
                var value = BaseValue + StaticModifiers.Values.Sum();
                value += DynamicModifiers.Values.Sum(dm => dm(value));
                if (value > Maximum)
                {
                    value = Maximum;
                }
                if (value < Minimum)
                {
                    value = Minimum;
                }
                if (value < Parent.LowerBound)
                {
                    value = Parent.LowerBound;
                }
                return value;
            }
        }

        /// <summary>
        /// StaticModifiers are summed and added to the underlying value
        /// for output.
        /// </summary>
        public Dictionary<string, decimal> StaticModifiers;
        /// <summary>
        /// Dynamic modifiers are summed and added to the value after static modifiers.
        /// </summary>
        public Dictionary<string, DynamicModifier> DynamicModifiers;

        public static implicit operator decimal(DecimalUpperBound bound)
        {
            return bound.Value;
        }

        public DecimalUpperBound(BoundedDecimalStat parent, decimal value = 9999, decimal minimum = 0, decimal maximum = 9999)
        {
            StaticModifiers = new Dictionary<string, decimal>();
            DynamicModifiers = new Dictionary<string, DynamicModifier>();

            Parent = parent;
            Minimum = minimum;
            Maximum = maximum;

            if (value > Maximum)
            {
                value = Maximum;
            }
            if (value < Minimum)
            {
                value = Minimum;
            }
            BaseValue = value;
        }
    }
}
