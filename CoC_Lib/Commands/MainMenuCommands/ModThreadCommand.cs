using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.MainMenuCommands
{
    public class ModThreadCommand : Command
    {
        public override string ShortName => "Mod Thread";
        public override string LongName => "Mod Thread";
        public override string CanExecuteDescription => "Check the official mod thread on Fenoxo's forum";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute() => throw new NotImplementedException();

        public ModThreadCommand(Game game)
            :base(game)
        { }
    }
}
