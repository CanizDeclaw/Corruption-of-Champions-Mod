using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class FinalizeAppearanceScene : CommonScene
    {
        public FinalizeAppearanceScene(Game game)
            : base(game)
        {
            Commands[0] = new ChooseComplexionCommand(game);
            Commands[1] = new ChooseHairColorCommand(game);
            Commands[2] = new ChooseBeardCommand(game); // Doesn't show for women, fem.Herm
            Commands[3] = new SetHeightCommand(game);
            Commands[4] = new ChooseCockSizeCommand(game); // Doesn't show for women
            Commands[5] = new ChooseBreastSizeCommand(game);
            if (true)
            {
                Commands[9] = new DoneCommand(game);
            }
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
