using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common_Game.Creatures.Statistics
{
    public class IntUpperBound
    {
        protected virtual BoundedIntegerStat Parent { get; }
        protected virtual int BaseValue { get; set; }
        public virtual int Minimum { get; }
        public virtual int Maximum { get; }
        public virtual int Value
        {
            get
            {
                var value = BaseValue + (int)StaticModifiers.Values.Sum();
                value += (int)DynamicModifiers.Values.Sum(dm => dm(value));
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

        public static implicit operator int(IntUpperBound bound)
        {
            return bound.Value;
        }

        public IntUpperBound(BoundedIntegerStat parent, int value = 9999, int minimum = 0, int maximum = 9999)
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
