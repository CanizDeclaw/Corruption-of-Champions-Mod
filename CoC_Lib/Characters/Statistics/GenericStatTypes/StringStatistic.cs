using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters.Statistics
{
    public abstract class StringStatistic : Statistic
    {
        public abstract string Value { get; }

        public StringStatistic(Creature creature)
            : base(creature)
        { }
    }
}
