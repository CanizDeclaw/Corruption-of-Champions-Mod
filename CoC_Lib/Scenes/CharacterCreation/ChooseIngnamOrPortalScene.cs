using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class ChooseIngnamOrPortalScene : CommonScene
    {
        public ChooseIngnamOrPortalScene(Game game)
            : base(game)
        {
            Commands[0] = new ChooseIngnamCommand(game);
            Commands[1] = new ChoosePortalCommand(game);
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
