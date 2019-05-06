using CoC_Lib.Characters;
using System;

namespace CoC_Lib
{
    public class Game
    {
        public ISaveLoad SaveLoad;
        public bool InProgress;
        public Player Player;
        public Scenes.Scene CurrentScene { get; }

        /// <summary>
        /// Set all game variables to clean, new-game state.  Used to start a new game,
        /// before loading a saved game, and on loading the game itself.
        /// </summary>
        protected void ResetGame() { }

        /// <summary>
        /// Start a new game.  Resets the game state and loads up the game beginning.
        /// </summary>
        protected void NewGame() { }

        public Game(ISaveLoad saveLoad)
        {
            SaveLoad = saveLoad;
            ResetGame();
            CurrentScene = new Scenes.MainMenu(this);
        }
    }
}
