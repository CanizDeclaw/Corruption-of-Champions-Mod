using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class ChooseComplexionScene : CommonScene
    {
        public ChooseComplexionScene(Game game)
            :base(game)
        {
            Commands[0] = new ChooseLightCommand(game);
            Commands[1] = new ChooseFairCommand(game);
            Commands[2] = new ChooseOliveCommand(game);
            Commands[3] = new ChooseDarkCommand(game);
            Commands[4] = new ChooseEbonyCommand(game);
            Commands[5] = new ChooseMahoganyCommand(game);
            Commands[6] = new ChooseRussetCommand(game);
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
