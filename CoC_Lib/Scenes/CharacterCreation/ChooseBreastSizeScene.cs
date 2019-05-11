using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class ChooseBreastSizeScene : CommonScene
    {
        public ChooseBreastSizeScene(Game game)
            : base(game)
        {
            Commands[0] = new ChooseFlatCommand(game);
            Commands[1] = new ChooseACupCommand(game);
            Commands[2] = new ChooseBCupCommand(game);
            Commands[3] = new ChooseCCupCommand(game);
            Commands[4] = new ChooseDCupCommand(game);
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
