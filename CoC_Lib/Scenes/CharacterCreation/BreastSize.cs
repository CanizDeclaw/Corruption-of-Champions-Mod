using System;
using System.Collections.Generic;
using System.Text;
using CoC_Lib.Creatures.BodyParts;
using CoC_Lib.Scenes.CharacterCreation.BreastSizeCommands;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class BreastSize : CommonScene
    {
        public BreastSize(Game game)
            : base(game)
        {
            var sizes = new BreastRow.BreastCup[]
                {
                    BreastRow.BreastCup.Flat,
                    BreastRow.BreastCup.A,
                    BreastRow.BreastCup.B,
                    BreastRow.BreastCup.C,
                    BreastRow.BreastCup.D,
                };
            for (int i = 0; i < sizes.Length; i++)
            {
                Commands[i] = new BreastSizeCommand(game, sizes[i]);
            }
            Commands[14] = new Commands.CommonCommands.BackCommand(game);
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
