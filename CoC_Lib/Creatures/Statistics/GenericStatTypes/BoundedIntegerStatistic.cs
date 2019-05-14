﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    // TODO: Reimplement Value, Minimum, and Maximum to be self-contained,
    //       with the latter two including their temporary limiters.
    //       Should also have multipart modifier (pre-setter, post-setter, etc).
    public abstract class BoundedIntegerStat : IntegerStat
    {
        #region Value
        // Overriding `Value` because now it has to pay attention to the limits and restrictions.
        // For now, we don't bother changing the base value to make it "fit" the restrictions.
        // Thus, if a restriction is removed, the value will bounce right back to where it was.
        // Except: when directly adjusting or setting the base value, which compensate so that the
        // result value is at the minimum or maximum, if needed.
        public override void AdjustBaseValue(int relativeAdjustment)
        {
            // Decimal values used to allow easy percentage modifications.
            decimal modifier = 0;
            foreach (var modFunction in OnBaseValueAdjusting.Values)
            {
                modifier += modFunction(relativeAdjustment);
            }
            var value = BaseValue + relativeAdjustment + (int)modifier;

            if (Value < Minimum)
            {
                value = Minimum - (int)ValueModifiers.Values.Sum(vm => vm(BaseValue));
            }
            else if (Value > Maximum)
            {
                value = Maximum - (int)ValueModifiers.Values.Sum(vm => vm(BaseValue));
            }

            BaseValue = value;
        }
        public override void SetBaseValue(int value)
        {
            if (Value < Minimum)
            {
                value = Minimum - (int)ValueModifiers.Values.Sum(vm => vm(BaseValue));
            }
            else if (Value > Maximum)
            {
                value = Maximum - (int)ValueModifiers.Values.Sum(vm => vm(BaseValue));
            }

            BaseValue = value;
        }
        public override int Value
        {
            get
            {
                var value = BaseValue + (int)ValueModifiers.Values.Sum(vm => vm(BaseValue));
                if (value > RestrictedMaximum)
                {
                    return RestrictedMaximum;
                }
                else if (value < RestrictedMinimum)
                {
                    return RestrictedMinimum;
                }
                return value;
            }
        }
        #endregion Value

        #region Minimum
        // The absolute lower limit of a stat.  For now this is always 0.
        protected int BaseMinimum => 0;
        public int Minimum { get => BaseMinimum; }
        #endregion Minimum

        #region Maximum
        // The absolute upper limit of a stat. Can't be lower than BaseMinimum.
        // TODO: Make use of these limits
        protected virtual int LowerLimitOfMax { get; set; } = 50;
        protected virtual int UpperLimitOfMax { get; set; } = 9999;
        protected virtual int BaseMaximum { get; set; }
        public virtual void AdjustBaseMaximum(int relativeAdjustment)
        {
            // Decimal values used to allow easy percentage modifications.
            decimal modifier = 0;
            foreach (var modFunction in OnBaseMaximumAdjusting.Values)
            {
                modifier += modFunction(relativeAdjustment);
            }
            var value = BaseMaximum + relativeAdjustment + (int)modifier;
            if (Maximum < Minimum)
            {
                value = Minimum - MaximumModifiers.Values.Sum();
            }
            BaseMaximum = value;
        }
        public virtual void SetBaseMaximum(int value)
        {
            if (Maximum < Minimum)
            {
                value = Minimum - MaximumModifiers.Values.Sum();
            }
            BaseMaximum = value;
        }
        public virtual int Maximum
        {
            get
            {
                var value = BaseMaximum + MaximumModifiers.Values.Sum();
                if (value < BaseMinimum)
                {
                    value = BaseMinimum;
                }
                return value;
            }
        }

        /// <summary>
        /// Delegate for modifying incoming adjustments.
        /// </summary>
        /// <param name="value">the base adjustment value.</param>
        /// <returns>the amount to adjust the adjustment value.</returns>
        public delegate decimal BaseMaximumAdjustmentModifier(decimal value);
        public Dictionary<object, BaseMaximumAdjustmentModifier> OnBaseMaximumAdjusting;

        public Dictionary<object, int> MaximumModifiers;
        #endregion Maximum

        #region Restricted Minimum & Restricted Maximum
        // These represent modified upper and lower limits due to temporary conditions and some perks.
        // The unchecked variants do the base calculation and allow the public variants to make sure
        // the boundaries don't overlap. If they do overlap, the average is taken and compared to both
        // the minimum and the maximum to make sure it doesn't exceed them, either.

        // Modifiers are applied on top of the chosen setter/minimum/maximum.
        protected bool BoundsOverlap => UncheckedRestrictedMinimum > UncheckedRestrictedMaximum;
        protected int OverlapAverage => (UncheckedRestrictedMinimum + UncheckedRestrictedMaximum) / 2;

        protected virtual int UncheckedRestrictedMinimum
        {
            get
            {
                var value = Minimum;
                if (RestrictedMinimumSetters.Count > 0)
                {
                    var maxSetter = RestrictedMinimumSetters.Values.Max();
                    value = Math.Max(value, maxSetter);
                }
                return value + RestrictedMinimumModifiers.Values.Sum();
            }
        }
        public virtual int RestrictedMinimum
        {
            get
            {
                var value = UncheckedRestrictedMinimum;
                if (BoundsOverlap)
                {
                    value = OverlapAverage;
                }
                value = Math.Max(value, Minimum);
                return Math.Min(value, Maximum);
            }
        }

        protected virtual int UncheckedRestrictedMaximum
        {
            get
            {
                var value = Minimum;
                if (RestrictedMinimumSetters.Count > 0)
                {
                    var minSetter = RestrictedMaximumSetters.Values.Min();
                    value = Math.Min(value, minSetter);
                }
                return value + RestrictedMaximumModifiers.Values.Sum();
            }
        }
        public virtual int RestrictedMaximum
        {
            get
            {
                var value = UncheckedRestrictedMaximum;
                if (BoundsOverlap)
                {
                    value = OverlapAverage;
                }
                value = Math.Max(value, Minimum);
                return Math.Min(value, Maximum);
            }
        }

        // Use these when you want to make a relative adjustment
        public Dictionary<object, int> RestrictedMinimumModifiers;
        public Dictionary<object, int> RestrictedMaximumModifiers;

        // Use these when you want to set an absolute limit
        public Dictionary<object, int> RestrictedMinimumSetters;
        public Dictionary<object, int> RestrictedMaximumSetters;
        #endregion Restricted Minimum & Restricted Maximum

        public BoundedIntegerStat(Game game, Creature creature)
            :base(game, creature)
        {
            MaximumModifiers = new Dictionary<object, int>();
            RestrictedMinimumModifiers = new Dictionary<object, int>();
            RestrictedMaximumModifiers = new Dictionary<object, int>();

            RestrictedMinimumSetters = new Dictionary<object, int>();
            RestrictedMaximumSetters = new Dictionary<object, int>();
        }   
    }       
}           
