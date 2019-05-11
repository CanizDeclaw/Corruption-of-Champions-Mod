using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class ChooseBeardStyleScene : CommonScene
    {
        public ChooseBeardStyleScene(Game game)
            : base(game)
        {

            Commands[0] = new ChooseNormalStyleCommand(game);
            Commands[1] = new ChooseGoateeCommand(game);
            Commands[2] = new ChooseCleanCutCommand(game);
            Commands[3] = new ChooseMountainManCommand(game);
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
