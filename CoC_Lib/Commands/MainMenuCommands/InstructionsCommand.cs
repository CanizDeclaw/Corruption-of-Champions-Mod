using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.MainMenuCommands
{
    public class InstructionsCommand : Command
    {
        public override string ShortName => "Instructions";
        public override string LongName => "Instructions";
        public override string CanExecuteDescription => "How to play. Starting tips. And hotkeys for easy left-handed play...";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override Action<Game> NextScene => throw new NotImplementedException();

        public InstructionsCommand(Game game)
            : base(game)
        { }
    }
}
