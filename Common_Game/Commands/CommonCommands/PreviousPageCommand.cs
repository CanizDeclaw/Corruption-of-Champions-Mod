using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Commands.CommonCommands
{
    public class PreviousPageCommand : Command
    {
        public override string ShortName => "Previous";
        public override string LongName => "Previous Page";
        public override string CanExecuteDescription => "Go to the previous page of commands.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute()
        {
            Game.NextScene();
        }

        public NextPageCommand(Game game)
            : base(game)
        {

        }
    }
}
