using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class ChoosePersonalGiftScene : CommonScene
    {
        public ChoosePersonalGiftScene(Game game)
            : base(game)
        {
            // Man/Woman
            Commands[0] = new ChooseStrongCommand(game);
            Commands[1] = new ChooseToughCommand(game);
            Commands[2] = new ChooseFastCommand(game);
            Commands[3] = new ChooseSmartsCommand(game);
            Commands[4] = new ChooseLibidoCommand(game);
            Commands[5] = new ChooseTouchCommand(game);
            Commands[6] = new ChoosePerversionCommand(game);
            Commands[7] = new ChooseBigCockCommand(game);  // Men
            Commands[7] = new ChooseBigBreastsCommand(game);  // Women
            Commands[8] = new ChooseLotsOfJizzCommand(game); // Men
            Commands[8] = new ChooseBigClitCommand(game); // Women
            Commands[9] = new ChooseFertileCommand(game); // Women
            Commands[10] = new ChooseWetVaginaCommand(game); // Women

            // Herm
            Commands[0] = new ChooseStrongCommand(game);
            Commands[1] = new ChooseToughCommand(game);
            Commands[2] = new ChooseFastCommand(game);
            Commands[3] = new ChooseSmartsCommand(game);
            Commands[4] = new ChooseLibidoCommand(game);
            Commands[5] = new ChooseTouchCommand(game);
            Commands[6] = new ChoosePerversionCommand(game);
            Commands[7] = new ChooseBigCockCommand(game);
            Commands[8] = new ChooseLotsOfJizzCommand(game);
            Commands[9] = new ChooseBigBreastsCommand(game);
            Commands[10] = new ChooseBigClitCommand(game);
            Commands[11] = new ChooseFertileCommand(game);
            Commands[12] = new ChooseWetVaginaCommand(game);
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
