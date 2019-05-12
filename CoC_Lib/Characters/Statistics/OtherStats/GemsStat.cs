using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters.Statistics
{
    public class GemsStat : IntegerStat
    {
        public override string Name => "Gems";
        public override string Description => "";
        public override int Value { get; set; } = 0;

        public GemsStat(Creature creature)
            : base(creature)
        { }
    }
}
