using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Common.Commands.CommonSceneMenuCommands
{
    public class StatsCommand : Command
    {
        public override string ShortName => "Stats";
        public override string LongName => "Your Statistics";
        public override string CanExecuteDescription => "Information about you and your relationships.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute() => throw new NotImplementedException();

        public StatsCommand(Game game)
            : base(game)
        { }
    }
}
