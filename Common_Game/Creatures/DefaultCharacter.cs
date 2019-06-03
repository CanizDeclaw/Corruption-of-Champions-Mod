using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Creatures
{
    class DefaultCharacter : Character
    {
        public DefaultCharacter()
            :base(new Bodies.HumanBody())
        {
        }
    }
}
