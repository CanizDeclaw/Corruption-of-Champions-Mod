using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class Complexion : CommonScene
    {
        public Complexion(Game game)
            :base(game)
        {
            Commands[0] = new LightComplexion(game);
            Commands[1] = new FairComplexion(game);
            Commands[2] = new OliveComplexion(game);
            Commands[3] = new DarkComplexion(game);
            Commands[4] = new EbonyComplexion(game);
            Commands[5] = new MahoganyComplexion(game);
            Commands[6] = new RussetComplexion(game);
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
