using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.CommonCommands
{
    class ContinueCommand : Command
    {
        public override string ShortName => "Continue";
        public override string LongName => "Continue";
        public override string CanExecuteDescription => "";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute()
        {
            Game.NextScene();
        }

        public ContinueCommand(Game game)
            : base(game)
        {

        }
    }
}
