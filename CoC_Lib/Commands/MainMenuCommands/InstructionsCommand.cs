using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.MainMenuCommands
{
    public class InstructionsCommand : Command
    {
        public override string ShortName => "Instructions";
        public override string CanExecuteDescription => "<h1>Instructions</h1><hr>How to play. Starting tips. And hotkeys for easy left-handed play...";
        public override string CanNotExecuteDescription => "";

        public override Func<Game, bool> CanExecute => (_) => true;
        public override Action<Game> NextScene => throw new NotImplementedException();

        public InstructionsCommand(Game game)
            : base(game)
        { }
    }
}
