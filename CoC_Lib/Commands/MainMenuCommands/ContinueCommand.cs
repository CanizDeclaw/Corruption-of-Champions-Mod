using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.MainMenuCommands
{
    public class ContinueCommand : Command
    {
        public override string ShortName => "Continue";
        public override string LongName => "Continue";
        public override string CanExecuteDescription => "Get back to gameplay?";
        public override string CanNotExecuteDescription => "Please start a new game or load an existing save file.";

        public override bool CanExecute => Game.InProgress;
        public override void Execute() => throw new NotImplementedException();

        public ContinueCommand(Game game)
            : base(game)
        { }
    }
}
