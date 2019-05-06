using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters.Statistics
{
    public abstract class BoundedScalarIntegerStat
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract int Minimum { get; }
        public abstract int Maximum { get; }
        public abstract int Value { get; }
    }
}
