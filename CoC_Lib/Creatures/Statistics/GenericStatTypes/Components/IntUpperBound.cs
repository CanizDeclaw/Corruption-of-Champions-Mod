using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class IntUpperBound
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

        public static implicit operator int(IntUpperBound bound)
        {
            return bound.Value;
        }

        public IntUpperBound()
        {
            BaseValue = 9999;
            Minimum = 0;
            Maximum = 9999;
        }
        public IntUpperBound(int value)
        {
            BaseValue = value;
            Minimum = 0;
            Maximum = 9999;
        }
        public IntUpperBound(int value = 9999, int minimum = 0, int maximum = 9999)
        {
            BaseValue = value;
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
