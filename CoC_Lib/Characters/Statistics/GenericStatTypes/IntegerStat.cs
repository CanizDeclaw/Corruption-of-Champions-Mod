using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters.Statistics
{
    public abstract class IntegerStat : ScalarStatistic
    {
        public abstract int Value { get; set; }

        public IntegerStat(Creature creature)
            :base(creature)
        { }
    }
}
