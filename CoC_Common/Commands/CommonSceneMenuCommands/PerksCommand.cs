using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.CommonSceneMenuCommands
{
    public class PerksCommand : Command
    {
        public override string ShortName => "Perks";
        public override string LongName => "Perks";
        public override string CanExecuteDescription => "View your perks.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute() => throw new NotImplementedException();

        public PerksCommand(Game game)
            : base(game)
        { }
    }
}
