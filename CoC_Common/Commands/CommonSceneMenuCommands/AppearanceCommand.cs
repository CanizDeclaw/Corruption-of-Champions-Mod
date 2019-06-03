using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.CommonSceneMenuCommands
{
    public class AppearanceCommand : Command
    {
        public override string ShortName => "Appearance";
        public override string LongName => "Your Appearance";
        public override string CanExecuteDescription => "See information about your appearance.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute() => throw new NotImplementedException();

        public AppearanceCommand(Game game)
            : base(game)
        { }
    }
}
