using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.MainMenuCommands
{
    public class OptionsCommand : Command
    {
        public override string ShortName => "Options";
        public override string CanExecuteDescription => "<h1>Options</h1><hr>Configure game settings and enable cheats.";
        public override string CanNotExecuteDescription => "";

        public override Func<Game, bool> CanExecute => (_) => true;
        public override Action<Game> NextScene => throw new NotImplementedException();

        public OptionsCommand(Game game)
            : base(game)
        { }
    }
}
