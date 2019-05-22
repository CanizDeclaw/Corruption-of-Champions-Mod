using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class IntMinimum
    {
        protected virtual BoundedIntegerStat Parent { get; }
        protected virtual int BaseValue { get => Parent.LowerBound; }

        internal virtual int UncheckedValue
        {
            get
            {
                var premodifier = BaseValue + PreSetterStaticModifiers.Values.Sum();
                var maxSetter = StaticSetters.Values.Max();
                var value = Math.Max(premodifier, maxSetter);
                value += PostSetterStaticModifiers.Values.Sum();
                return value;
            }
        }
        /// <summary>
        /// Final value is calculated as follows:
        /// PreSetterStaticModifiers are summed and added to UpperBound.
        /// This is compared to all StaticSetters to find the highest value.
        /// Highest value is selected and added to the sum of the PostSetterStaticModifiers.
        /// Value is checked against container's Maximum to ensure no crossing.
        /// Value is checked against container's UpperBound and LowerBound to ensure within bounds.
        /// </summary>
        public virtual int Value
        {
            get
            {
                var value = UncheckedValue;
                if (DynamicUpperBounds.Count > 0 &&
                    value > DynamicUpperBounds.Values.Min(dub => dub()))
                {
                    value = DynamicUpperBounds.Values.Min(dub => dub());
                }
                if (value > Parent.Maximum.UncheckedValue)
                {
                    value = (UncheckedValue + Parent.Maximum.UncheckedValue) / 2;
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
        public Dictionary<object, Func<int>> DynamicSetters;
        public Dictionary<object, int> PostSetterStaticModifiers;

        public Dictionary<object, Func<int>> DynamicUpperBounds;

        public static implicit operator int(IntMinimum bound)
        {
            return bound.Value;
        }

        public IntMinimum(BoundedIntegerStat parent)
        {
            Parent = parent;
        }
    }
}
