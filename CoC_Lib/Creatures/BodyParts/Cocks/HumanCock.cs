using System;
using System.Collections.Generic;
using System.Text;
using CoC_Lib.Creatures.Species;

namespace CoC_Lib.Creatures.BodyParts.Cocks
{
    class HumanCock : Cock
    {
        public override bool SupportsKnot => false;
        public override Species.Type Species => Creatures.Species.Type.Human;
    }
}
