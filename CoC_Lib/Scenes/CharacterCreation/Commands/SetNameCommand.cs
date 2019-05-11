using CoC_Lib.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation.Commands
{
    class SetNameCommand : Command
    {
        public override string ShortName => "Set Name";
        public override string LongName => "Set Name";
        public override string CanExecuteDescription => "Set your name to _";
        public override string CanNotExecuteDescription => "Please enter a name into the textbox.";

        public override bool CanExecute => true;
        public override void Execute()
        {
            throw new NotImplementedException();
        }

        public SetNameCommand(Game game, string nameBoxKey)
            :base(game)
        {
            TextboxKeys.Add(nameBoxKey);
        }
    }
}
