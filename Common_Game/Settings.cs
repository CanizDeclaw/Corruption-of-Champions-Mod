using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game
{
    public abstract class Settings
    {
        // Typically this will be the starting menu for the game, unless your game
        // jumps right in.
        public abstract Scenes.HomeScene DefaultHomeScene { get; }
    }
}
