using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters.Statistics
{
    public abstract class BoundedScalarIntegerStat : IntegerStat
    {
        public abstract int Minimum { get; }
        public abstract int Maximum { get; }

        public BoundedScalarIntegerStat(Creature creature)
            :base(creature)
        { }
    }
}
