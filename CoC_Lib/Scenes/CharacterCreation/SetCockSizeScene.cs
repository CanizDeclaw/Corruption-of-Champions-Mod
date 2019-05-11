using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class SetCockSizeScene : CommonScene
    {
        public SetCockSizeScene(Game game)
            : base(game)
        {

            Commands[0] = new Choose4InchesCommand(game);
            Commands[1] = new Choose4_5InchesCommand(game);
            Commands[2] = new Choose5InchesCommand(game);
            Commands[3] = new Choose5_5InchesCommand(game);
            Commands[4] = new Choose6InchesCommand(game);
            Commands[5] = new Choose6_5InchesCommand(game);
            Commands[6] = new Choose7InchesCommand(game);
            Commands[5] = new Choose7_5InchesCommand(game);
            Commands[6] = new Choose8InchesCommand(game);
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
