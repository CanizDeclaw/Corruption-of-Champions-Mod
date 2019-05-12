using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters
{
    class DefaultCharacter : Character
    {
        public DefaultCharacter()
            :base(new Bodies.HumanBody())
        {
        }
    }
}
