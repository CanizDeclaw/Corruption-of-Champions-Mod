using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common_Game.Creatures.Statistics
{
    public class IntMinimum
    {
        protected virtual BoundedIntegerStat Parent { get; }
        protected virtual int BaseValue { get => Parent.LowerBound; }
        protected virtual int BaseLowerLimit { get => Parent.LowerBound; }
        protected virtual int BaseUpperLimit { get => Parent.UpperBound; }

        /// <summary>
        /// Upper limit of the minimum.
        /// </summary>
        protected int UpperLimit
        {
            get
            {
                var upperLimit = BaseUpperLimit;
                if (UpperLimitStaticSetters.Count > 0)
                {
                    var lowestSetter = UpperLimitStaticSetters.Values.Min();
                    upperLimit = Math.Min(upperLimit, lowestSetter);
                }

                return upperLimit;
            }
        }

        // UpperLimit modifiers
        public Dictionary<string, int> UpperLimitStaticSetters;

        /// <summary>
        /// The value of Minimum before checking against Maximum.
        /// </summary>
        internal virtual int UncheckedValue
        {
            get
            {
                var value = BaseValue + PreSetterStaticModifiers.Values.Sum();
                if (StaticSetters.Count > 0)
                {
                    var maxStaticSetter = StaticSetters.Values.Max();
                    value = Math.Max(value, maxStaticSetter);
                }
                if (DynamicSetters.Count > 0)
                {
                    var maxDynamicSetter = DynamicSetters.Values.Max(ds => ds());
                    value = Math.Max(value, maxDynamicSetter);
                }
                value += PostSetterStaticModifiers.Values.Sum();

                if (value > UpperLimit)
                {
                    value = UpperLimit;
                }
                if (value < BaseLowerLimit)
                {
                    value = BaseLowerLimit;
                }
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
                if (value > Parent.Maximum.UncheckedValue)
                {
                    value = (UncheckedValue + Parent.Maximum.UncheckedValue) / 2;
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

        public static implicit operator int(IntMinimum bound)
        {
            return bound.Value;
        }

        public IntMinimum(BoundedIntegerStat parent)
        {
            UpperLimitStaticSetters = new Dictionary<string, int>();

            PreSetterStaticModifiers = new Dictionary<string, int>();
            StaticSetters = new Dictionary<string, int>();
            DynamicSetters = new Dictionary<string, DynamicSetter>();
            PostSetterStaticModifiers = new Dictionary<string, int>();
            PostSetterDynamicModifiers = new Dictionary<string, DynamicModifier>();

            Parent = parent;
        }
    }
}
