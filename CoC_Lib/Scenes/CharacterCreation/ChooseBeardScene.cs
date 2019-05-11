using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class ChooseBeardScene : CommonScene
    {
        public ChooseBeardScene(Game game)
            : base(game)
        {

            Commands[0] = new ChooseStyleCommand(game);
            Commands[1] = new ChooseLengthCommand(game);
            if (true)
            {
                Commands[14] = new BackCommand(game);
            }
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
