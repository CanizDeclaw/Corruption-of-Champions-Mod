using System;
using System.Collections.Generic;
using System.Text;
using CoC_Lib.Creatures.Species;

namespace CoC_Lib.Creatures.BodyParts.Vaginas
{
    class HumanVagina : Vagina
    {
        public override Species.Type Species => Creatures.Species.Type.Human;
    }
}
