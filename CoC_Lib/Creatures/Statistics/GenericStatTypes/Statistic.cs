using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public abstract class Statistic
    {
        protected readonly Creature creature;
        public abstract string Name { get; }
        public abstract string Description { get; }

        public Statistic(Creature creature)
        {
            this.creature = creature;
        }
    }
}
