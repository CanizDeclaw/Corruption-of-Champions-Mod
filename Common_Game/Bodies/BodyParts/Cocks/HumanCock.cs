using System;
using System.Collections.Generic;
using System.Text;
using Common_Game.Creatures.Species;

namespace Common_Game.Bodies.BodyParts.Cocks
{
    class HumanCock : Cock
    {
        public override bool SupportsKnot => false;
        public override Species.Type Species => Creatures.Species.Type.Human;
    }
}
