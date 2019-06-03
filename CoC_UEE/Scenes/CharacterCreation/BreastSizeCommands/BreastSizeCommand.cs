using CoC_Lib.Creatures.BodyParts;
using CoC_Lib.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation.BreastSizeCommands
{
    public class BreastSizeCommand : Command
    {
        // TODO: BreastRow.BreastRating => string
        public override string ShortName => BreastRow.Size.ToString();
        public override string LongName => BreastRow.Size.ToString();
        public override string CanExecuteDescription => $"Set your breast size to {BreastRow.Size.ToString()}";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute()
        {
            Game.Player.Breasts[0] = BreastRow;
            Game.NextScene();
        }

        private readonly BreastRow BreastRow;

        public BreastSizeCommand(Game game, BreastRow.BreastCup cupSize)
            : base(game)
        {
            BreastRow = new Creatures.Bodies.HumanBodyParts.HumanBreastRow();
            BreastRow.Size = cupSize;
        }
    }
}
