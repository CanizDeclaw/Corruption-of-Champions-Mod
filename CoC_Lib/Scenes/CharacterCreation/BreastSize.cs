using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class BreastSize : CommonScene
    {
        public BreastSize(Game game)
            : base(game)
        {
            Commands[0] = new Flat(game);
            Commands[1] = new A_Cup(game);
            Commands[2] = new B_Cup(game);
            Commands[3] = new C_Cup(game);
            Commands[4] = new D_Cup(game);
            if (true)
            {
                Commands[14] = new Commands.CommonCommands.BackCommand(game);
            }
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
