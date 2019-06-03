using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Commands.CommonCommands
{
    public class NextPageCommand : Command
    {
        public override string ShortName => "Next";
        public override string LongName => "Next Page";
        public override string CanExecuteDescription => "Go to the next page of commands.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute()
        {
            Game.NextScene();
        }

        public PreviousPageCommand(Game game)
            : base(game)
        {

        }
    }
}
