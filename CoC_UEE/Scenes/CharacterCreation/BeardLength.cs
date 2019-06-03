using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class ChooseBeardLengthScene : CommonScene
    {
        public ChooseBeardLengthScene(Game game)
            : base(game)
        {
            Commands[0] = new NoBeard(game);
            Commands[1] = new TrimmedBeard(game);
            Commands[2] = new ShortBeard(game);
            Commands[3] = new MediumBeard(game);
            Commands[4] = new MediumLongBeard(game);
            Commands[5] = new LongBeard(game);
            Commands[6] = new VeryLongBeard(game);
            if (true)
            {
                Commands[14] = new Commands.CommonCommands.BackCommand(game);
            }
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
