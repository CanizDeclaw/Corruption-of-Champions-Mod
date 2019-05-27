using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    // TODO: Figure out how Minimum and Maximum interact with everything else.
    public class DecimalLowerBound
    {
        protected virtual decimal BaseValue { get; set; }
        public virtual decimal Value
        {
            get
            {
                var value = BaseValue + StaticModifiers.Values.Sum();
                if (value > Maximum)
                {
                    value = Maximum;
                }
                if (value < Minimum)
                {
                    value = Minimum;
                }
                return value;
            }
        }
        public virtual decimal Minimum { get; }
        public virtual decimal Maximum { get; }

        /// <summary>
        /// StaticModifiers are summed and added to the underlying value
        /// for output.
        /// </summary>
        public Dictionary<string, decimal> StaticModifiers;

        public static implicit operator decimal(DecimalLowerBound bound)
        {
            return bound.Value;
        }

        public DecimalLowerBound(decimal value = 0, decimal minimum = 0, decimal maximum = 9999)
        {
            StaticModifiers = new Dictionary<string, decimal>();

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
