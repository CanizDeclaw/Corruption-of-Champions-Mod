using CoC_Lib.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class BaseBuildCommand : Command
    {
        public override string ShortName => "Back";
        public override string LongName => "Back";
        public override string CanExecuteDescription => "Go back to the previous page";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute()
        {
            Game.NextScene();
        }

        public BackCommand(Game game)
            : base(game)
        {

        }
    }
}
