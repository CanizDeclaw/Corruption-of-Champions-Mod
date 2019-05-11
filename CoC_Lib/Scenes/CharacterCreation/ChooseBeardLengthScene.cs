using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class ChooseBeardLengthScene : CommonScene
    {
        public ChooseBeardStyleScene(Game game)
            : base(game)
        {

            Commands[0] = new ChooseNoBeardCommand(game);
            Commands[1] = new ChooseTrimmedBeardCommand(game);
            Commands[2] = new ChooseShortBeardCommand(game);
            Commands[3] = new ChooseMediumBeardCommand(game);
            Commands[4] = new ChooseMediumLongBeardCommand(game);
            Commands[5] = new ChooseLongBeardCommand(game);
            Commands[6] = new ChooseVeryLongBeardCommand(game);
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
