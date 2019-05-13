using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures
{
    class DefaultCharacter : Character
    {
        public DefaultCharacter()
            :base(new Bodies.HumanBody())
        {
        }
    }
}
