using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.MainMenuCommands
{
    public class AchievementsCommand : Command
    {
        public override string ShortName => "Achievements";
        public override string CanExecuteDescription => "<h1>Achievements</h1><hr>View all achievements you have earned so far.";
        public override string CanNotExecuteDescription => "";

        public override Func<Game, bool> CanExecute => (_) => true;
        public override Action<Game> NextScene => throw new NotImplementedException();

        public AchievementsCommand(Game game)
            : base(game)
        { }
    }
}
