using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.CommonSceneMenuCommands
{
    public class DataCommand : Command
    {
        public override string ShortName => "Data";
        public override string LongName => "Data";
        public override string CanExecuteDescription => "Load or manage saved games.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute() => throw new NotImplementedException();

        public DataCommand(Game game)
            : base(game)
        { }
    }
}
