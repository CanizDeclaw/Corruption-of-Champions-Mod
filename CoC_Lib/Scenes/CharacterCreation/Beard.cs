using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class Beard : CommonScene
    {
        public Beard(Game game)
            : base(game)
        {
            Commands[0] = new BeardStyleCommand(game);
            Commands[1] = new BeardLengthCommand(game);
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
