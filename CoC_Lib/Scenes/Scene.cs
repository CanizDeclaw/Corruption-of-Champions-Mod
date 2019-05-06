using System;
using System.Collections.Generic;
using System.Text;
using CoC_Lib.Commands;

namespace CoC_Lib.Scenes
{
    /// <summary>
    /// Abstract base class for all scene classes.
    /// </summary>
    public abstract class Scene
    {
        public Game Game { get; }

        // Each scene has a max of 15 non-default action choices, not including the static(-ish)
        // choices like "Main Menu" and "Appearance".  Scenes are not guaranteed to use all
        // slots, nor to use them sequentially.
        public Command[] Commands { get; } = new Command[15];

        public Scene(Game game)
        {
            Game = game;
        }
    }
}
