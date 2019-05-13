using CoC_Lib.Creatures.BodyParts;
using CoC_Lib.Creatures.Species;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Bodies.HumanBodyParts
{
    public class HumanBreastRow : BreastRow
    {
        public override Species.Type Species => Creatures.Species.Type.Human;
    }
}
