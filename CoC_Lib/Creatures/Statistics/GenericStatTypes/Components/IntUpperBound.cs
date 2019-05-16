using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class IntUpperBound
    {
        public virtual int Value { get; }
        public virtual int Minimum { get; }
        public virtual int Maximum { get; }

        public static implicit operator int(IntUpperBound bound)
        {
            return bound.Value;
        }

        public IntUpperBound()
        {
            Value = 9999;
            Minimum = 0;
            Maximum = 9999;
        }
        public IntUpperBound(int value)
        {
            Value = value;
            Minimum = value;
            Maximum = value;
        }
        public IntUpperBound(int value, int minimum, int maximum)
        {
            Value = value;
            Minimum = minimum;
            Maximum = maximum;
        }
    }
}
