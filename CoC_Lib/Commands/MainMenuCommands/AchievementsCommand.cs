using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.MainMenuCommands
{
    public class AchievementsCommand : Command
    {
        public override string ShortName => "Achievements";
        public override string LongName => "Achievements";
        public override string CanExecuteDescription => "View all achievements you have earned so far.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override Action<Game> NextScene => throw new NotImplementedException();

        public AchievementsCommand(Game game)
            : base(game)
        { }
    }
}
