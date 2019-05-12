using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class FinalizeAppearance : CommonScene
    {
        public FinalizeAppearance(Game game)
            : base(game)
        {
            Commands[0] = new ChangeComplexion(game);
            Commands[1] = new ChangeHairColor(game);
            if (game.Player.HasBeard == true)
            {
                Commands[2] = new ChangeBeard(game);
            }
            Commands[3] = new ChangeHeight(game);
            if (game.Player.HasCock == true)
            {
                Commands[4] = new ChangeCockSize(game);
            }
            Commands[5] = new ChangeBreastSize(game);
            if (true)
            {
                Commands[9] = new FinalizeAppearanceCommand(game);
            }
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
