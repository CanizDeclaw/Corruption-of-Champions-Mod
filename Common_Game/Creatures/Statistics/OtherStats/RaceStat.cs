using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Creatures.Statistics
{
    public class RaceStat : StringStatistic
    {
        // TODO: Should this be Species?
        public override string Name => "Race";
        public override string Description => "Race";
        public override string Value => creature.RaceString;

        public RaceStat(Game game, Creature creature)
            : base(game, creature)
        { }
    }
}
