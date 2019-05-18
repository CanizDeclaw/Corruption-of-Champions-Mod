using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    // TODO: Figure out how Minimum and Maximum interact with everything else.
    public class IntLowerBound
    {
        protected virtual int BaseValue { get; set; }
        public virtual int Value
        {
            get
            {
                var value = BaseValue + (int)StaticModifiers.Values.Sum();
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
        public virtual int Minimum { get; }
        public virtual int Maximum { get; }


        /// <summary>
        /// StaticModifiers are summed and added to the underlying value
        /// for output.
        /// </summary>
        public Dictionary<object, decimal> StaticModifiers;

        public static implicit operator int(IntLowerBound bound)
        {
            return bound.Value;
        }

        public IntLowerBound(int value = 0, int minimum = 0, int maximum = 9999)
        {
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
