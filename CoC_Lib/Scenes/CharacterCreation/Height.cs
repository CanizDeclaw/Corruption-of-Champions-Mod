using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class Height : CommonScene
    {
        public Height(Game game)
            : base(game)
        {
            Commands[0] = new SetHeight(game, heightBoxKey);
            Commands[5] = new Commands.CommonCommands.BackCommand(game);
        }

        protected string heightBoxKey = "heightBox";
        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
