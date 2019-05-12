using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class HairColor : CommonScene
    {
        public HairColor(Game game)
            : base(game)
        {
            Commands[0] = new BlondeHair(game);
            Commands[1] = new BrownHair(game);
            Commands[2] = new BlackHair(game);
            Commands[3] = new RedHair(game);
            Commands[4] = new GrayHair(game);
            Commands[5] = new WhiteHair(game);
            Commands[6] = new AuburnHair(game);
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
