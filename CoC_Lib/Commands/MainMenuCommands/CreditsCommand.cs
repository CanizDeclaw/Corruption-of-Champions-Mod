using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.MainMenuCommands
{
    public class CreditsCommand : Command
    {
        public override string ShortName => "Credits";
        public override string LongName => "Credits";
        public override string CanExecuteDescription => "See a list of all the cool people who have contributed to content for this game!";
        public override string CanNotExecuteDescription => "";

        public override Func<Game, bool> CanExecute => (_) => true;
        public override Action<Game> NextScene => throw new NotImplementedException();

        public CreditsCommand(Game game)
            : base(game)
        { }
    }
}
