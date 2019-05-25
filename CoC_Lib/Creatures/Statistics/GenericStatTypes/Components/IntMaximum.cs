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
        protected virtual int BaseLowerLimit { get => Parent.LowerBound; }
        protected virtual int BaseUpperLimit { get => Parent.UpperBound; }

        /// <summary>
        /// Upper limit of the minimum.
        /// </summary>
        protected int LowerLimit
        {
            get
            {
                var lowerLimit = BaseLowerLimit;
                if (LowerLimitStaticSetters.Count > 0)
                {
                    var highestSetter = LowerLimitStaticSetters.Values.Max();
                    lowerLimit = Math.Max(lowerLimit, highestSetter);
                }

                return lowerLimit;
            }
        }

        // UpperLimit modifiers
        public Dictionary<string, int> LowerLimitStaticSetters;

        /// <summary>
        /// The value of Maximum before checking against Minimum.
        /// </summary>
        internal virtual int UncheckedValue
        {
            get
            {
                var value = BaseValue + PreSetterStaticModifiers.Values.Sum();
                if (StaticSetters.Count > 0)
                {
                    var minSetter = StaticSetters.Values.Min();
                    value = Math.Min(value, minSetter);
                }
                if (DynamicSetters.Count > 0)
                {
                    var minDynamicSetter = DynamicSetters.Values.Min(ds => ds());
                    value = Math.Min(value, minDynamicSetter);
                }
                value += PostSetterStaticModifiers.Values.Sum();

                if (value < LowerLimit)
                {
                    value = LowerLimit;
                }
                if (value > BaseUpperLimit)
                {
                    value = BaseUpperLimit;
                }
                return value;
            }
        }

        /// <summary>
        /// Final value is calculated as follows:
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
                return value;
            }
        }

        // Value modifiers
        public Dictionary<string, int> PreSetterStaticModifiers;
        public Dictionary<string, int> StaticSetters;
        public Dictionary<string, DynamicSetter> DynamicSetters;
        public Dictionary<string, int> PostSetterStaticModifiers;
        public Dictionary<string, DynamicModifier> PostSetterDynamicModifiers;

        public static implicit operator int(IntMaximum bound)
        {
            return bound.Value;
        }

        public IntMaximum(BoundedIntegerStat parent)
        {
            LowerLimitStaticSetters = new Dictionary<string, int>();

            PreSetterStaticModifiers = new Dictionary<string, int>();
            StaticSetters = new Dictionary<string, int>();
            DynamicSetters = new Dictionary<string, DynamicSetter>();
            PostSetterStaticModifiers = new Dictionary<string, int>();
            PostSetterDynamicModifiers = new Dictionary<string, DynamicModifier>();

            Parent = parent;
        }
    }
}
