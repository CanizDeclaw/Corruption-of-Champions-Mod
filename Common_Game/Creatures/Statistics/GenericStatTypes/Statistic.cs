using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Creatures.Statistics
{
    public abstract class Statistic : NotifyPropertyChangedBase
    {
        protected readonly Creature creature;
        protected readonly Game game;
        public abstract string Name { get; }
        public abstract string Description { get; }

        public Statistic(Game game, Creature creature)
        {
            this.game = game;
            this.creature = creature;
        }
    }
}
