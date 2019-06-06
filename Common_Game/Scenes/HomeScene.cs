using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Scenes
{
    public abstract class HomeScene : CommonScene
    {
        public abstract string Key { get; }

        public HomeScene(Game game)
            :base(game)
        {
        }
    }
}
