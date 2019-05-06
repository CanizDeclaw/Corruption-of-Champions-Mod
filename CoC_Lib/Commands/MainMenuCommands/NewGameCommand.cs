using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.MainMenuCommands
{
    public class NewGameCommand : Command
    {
        public override string ShortName => "New Game";
        public override string CanExecuteDescription => "<h1>New Game</h1><hr>Start a new game.";
        public override string CanNotExecuteDescription => "";

        public override Func<Game, bool> CanExecute => (_) => true;
        public override Action<Game> NextScene => throw new NotImplementedException();

        public NewGameCommand(Game game)
            : base(game)
        { }
    }
}
