using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.MainMenuCommands
{
    public class NewGameCommand : Command
    {
        public override string ShortName => "New Game";
        public override string LongName => "New Game";
        public override string CanExecuteDescription => "Start a new game.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute()
        {
            Game.NewGame();
        }

        public NewGameCommand(Game game)
            : base(game)
        { }
    }
}
