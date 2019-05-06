﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.MainMenuCommands
{
    public class DataCommand : Command
    {
        public override string ShortName => "Data";
        public override string LongName => "Data";
        public override string CanExecuteDescription => "Load or manage saved games.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override Action<Game> NextScene => throw new NotImplementedException();

        public DataCommand(Game game)
            : base(game)
        { }
    }
}
