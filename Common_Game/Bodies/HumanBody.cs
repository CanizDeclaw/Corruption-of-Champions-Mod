﻿using System;
using System.Collections.Generic;
using System.Text;
using Common_Game.Bodies.BodyMods;
using Common_Game.Bodies.BodyParts;

namespace Common_Game.Bodies
{
    /// <summary>
    /// A Human body.  Also represents the default body of the game.
    /// </summary>
    public class HumanBody : Body
    {
        public HumanBody()
            :base()
        {
        }
        public HumanBody(Body body)
            : base(body)
        {
        }
    }
}