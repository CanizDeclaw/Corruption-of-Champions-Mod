using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.MainMenuCommands
{
    public class OptionsCommand : Command
    {
        public override string ShortName => "Options";
        public override string LongName => "Options";
        public override string CanExecuteDescription => "Configure game settings and enable cheats.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override Action<Game> NextScene => throw new NotImplementedException();

        public OptionsCommand(Game game)
            : base(game)
        { }
    }
}
