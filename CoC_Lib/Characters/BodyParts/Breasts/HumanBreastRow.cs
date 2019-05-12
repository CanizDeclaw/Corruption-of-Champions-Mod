using CoC_Lib.Characters.BodyParts;
using CoC_Lib.Characters.Species;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters.Bodies.HumanBodyParts
{
    public class HumanBreastRow : BreastRow
    {
        public override Species.Type Species => Characters.Species.Type.Human;
    }
}
