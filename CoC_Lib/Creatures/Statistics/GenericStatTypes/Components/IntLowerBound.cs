using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class IntLowerBound
    {
        public virtual int Value { get; }
        public virtual int Minimum { get; }
        public virtual int Maximum { get; }

        public static implicit operator int(IntLowerBound bound)
        {
            return bound.Value;
        }

        public IntLowerBound()
        {
            Value = 0;
            Minimum = 0;
            Maximum = 9999;
        }
        public IntLowerBound(int value)
        {
            Value = value;
            Minimum = value;
            Maximum = value;
        }
        public IntLowerBound(int value, int minimum, int maximum)
        {
            Value = value;
            Minimum = minimum;
            Maximum = maximum;
        }
    }
}
