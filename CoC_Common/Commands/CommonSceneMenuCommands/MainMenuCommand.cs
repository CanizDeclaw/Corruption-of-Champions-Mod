using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.CommonSceneMenuCommands
{
    public class MainMenuCommand : Command
    {
        public override string ShortName => "Main Menu";
        public override string LongName => "Main Menu";
        public override string CanExecuteDescription => "Return to the main menu.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute() => throw new NotImplementedException();

        public MainMenuCommand(Game game)
            : base(game)
        { }
    }
}
