using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class IntMaximum
    {
        protected virtual BoundedIntegerStat Parent { get; }
        protected virtual int BaseValue { get => Parent.UpperBound; }

        internal virtual int UncheckedValue
        {
            get
            {
                var premodifier = BaseValue + PreSetterStaticModifiers.Values.Sum();
                var maxSetter = StaticSetters.Values.Min();
                var value = Math.Min(premodifier, maxSetter);
                value += PostSetterStaticModifiers.Values.Sum();
                return value;
            }
        }
        /// <summary>
        /// Final value is calculate as follows:
        /// PreSetterStaticModifiers are summed and added to UpperBound.
        /// This is compared to all StaticSetters to find the lowest value.
        /// Lowest value is selected and added to the sum of the PostSetterStaticModifiers.
        /// Value is checked against container's Minimum to ensure no crossing.
        /// Value is checked against container's UpperBound and LowerBound to ensure within bounds.
        /// </summary>
        public virtual int Value
        {
            get
            {
                var value = UncheckedValue;
                if (value > Parent.Minimum.UncheckedValue)
                {
                    value = (UncheckedValue + Parent.Minimum.UncheckedValue) / 2;
                }

                if (value > Parent.UpperBound)
                {
                    value = Parent.UpperBound;
                }
                else if (value < Parent.LowerBound)
                {
                    value = Parent.LowerBound;
                }
                return value;
            }
        }

        public Dictionary<object, int> PreSetterStaticModifiers;
        public Dictionary<object, int> StaticSetters;
        public Dictionary<object, int> PostSetterStaticModifiers;

        public static implicit operator int(IntMaximum bound)
        {
            return bound.Value;
        }

        public IntMaximum(BoundedIntegerStat parent)
        {
            Parent = parent;
        }
    }
}
