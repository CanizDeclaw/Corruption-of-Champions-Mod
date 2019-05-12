using System;
using System.Collections.Generic;
using System.Text;
using CoC_Lib.Characters.Species;

namespace CoC_Lib.Characters.BodyParts.Cocks
{
    class HumanCock : Cock
    {
        public override bool SupportsKnot => false;
        public override Species.Type Species => Characters.Species.Type.Human;
    }
}
