using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class CockSize : CommonScene
    {
        public CockSize(Game game)
            : base(game)
        {
            var sizes = new double[] { 4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8 };
            for (int i = 0; i < sizes.Length; i++)
            {
                Commands[i] = new CockSizeCommand(game, sizes[i]);
            }
            Commands[14] = new Commands.CommonCommands.BackCommand(game);
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
