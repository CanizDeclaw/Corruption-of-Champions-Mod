using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class ChooseHairColorScene : CommonScene
    {
        public ChooseHairColorScene(Game game)
            : base(game)
        {

            Commands[0] = new ChooseBlondeCommand(game);
            Commands[1] = new ChooseBrownCommand(game);
            Commands[2] = new ChooseBlackCommand(game);
            Commands[3] = new ChooseRedCommand(game);
            Commands[4] = new ChooseGrayCommand(game);
            Commands[5] = new ChooseWhiteCommand(game);
            Commands[6] = new ChooseAuburnCommand(game);
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
