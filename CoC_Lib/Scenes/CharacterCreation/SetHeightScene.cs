using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class SetHeightScene : CommonScene
    {
        public SetHeightScene(Game game)
            : base(game)
        {

            Commands[0] = new ChooseOkHeightCommand(game);
            if (true)
            {
                Commands[5] = new BackCommand(game);
            }
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
