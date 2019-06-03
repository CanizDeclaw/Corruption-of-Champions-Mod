using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class BeardStyle : CommonScene
    {
        public BeardStyle(Game game)
            : base(game)
        {
            Commands[0] = new NormalBeard(game);
            Commands[1] = new Goatee(game);
            Commands[2] = new CleanCutBeard(game);
            Commands[3] = new MountainManBeard(game);
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
