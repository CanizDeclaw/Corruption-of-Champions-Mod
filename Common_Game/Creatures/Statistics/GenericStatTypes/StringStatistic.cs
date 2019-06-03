using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Creatures.Statistics
{
    public abstract class StringStatistic : Statistic
    {
        public abstract string Value { get; }

        public StringStatistic(Game game, Creature creature)
            : base(game, creature)
        { }
    }
}
