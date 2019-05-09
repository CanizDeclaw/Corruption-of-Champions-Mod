using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters.Statistics
{
    public abstract class StringStatistic
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string Value { get; }
    }
}
