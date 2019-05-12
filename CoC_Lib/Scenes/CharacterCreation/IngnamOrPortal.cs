using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class IngnamOrPortal : CommonScene
    {
        public IngnamOrPortal(Game game)
            : base(game)
        {
            Commands[0] = new Ingnam(game);
            Commands[1] = new Portal(game);
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
