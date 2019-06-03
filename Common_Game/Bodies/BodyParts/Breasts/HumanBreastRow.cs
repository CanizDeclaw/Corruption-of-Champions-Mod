using Common_Game.Bodies.BodyParts;
using Common_Game.Creatures.Species;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Bodies.HumanBodyParts
{
    public class HumanBreastRow : BreastRow
    {
        public override Species.Type Species => Creatures.Species.Type.Human;
    }
}
