﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Creatures.Statistics
{
    public class GemsStat : IntegerStat
    {
        public override string Name => "Gems";
        public override string Description => "Gems";

        public GemsStat(Game game, Creature creature)
            : base(game, creature)
        {
            Value = new IntValue(noNegatives: true);
        }
    }
}