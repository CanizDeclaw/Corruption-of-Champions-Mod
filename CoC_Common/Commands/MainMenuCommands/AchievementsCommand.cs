﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Common.Commands.MainMenuCommands
{
    public class AchievementsCommand : Command
    {
        public override string ShortName => "Achievements";
        public override string LongName => "Achievements";
        public override string CanExecuteDescription => "View all achievements you have earned so far.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute() => throw new NotImplementedException();

        public AchievementsCommand(Game game)
            : base(game)
        { }
    }
}