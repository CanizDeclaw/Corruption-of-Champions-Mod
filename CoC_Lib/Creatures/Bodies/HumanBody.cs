﻿using System;
using System.Collections.Generic;
using System.Text;
using BodyMods;
using CoC_Lib.Creatures.BodyParts;

namespace CoC_Lib.Creatures.Bodies
{
    /// <summary>
    /// A Human body.  Also represents the default body of the game.
    /// </summary>
    public class HumanBody : Body
    {
        public HumanBody(Game game, Creature creature)
            :base(game, creature)
        {
        }
        public HumanBody(Game game, Creature creature, Body body)
            : base(game, creature, body)
        {
        }
    }
}
