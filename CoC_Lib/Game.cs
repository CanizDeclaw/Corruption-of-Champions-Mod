using CoC_Lib.Characters;
using System;

namespace CoC_Lib
{
    public class Game
    {
        public ISaveLoad SaveLoad;
        public string VersionText => "1.0.2_mod_2.0.0-alpha (C# Port), Dev Build";
        public bool InProgress;
        public Player Player { get; private set; }
        public TimeSpan GameTime { get; private set; }
        public int Day => GameTime.Days;
        public TimeSpan TimeOfDay => GameTime.Subtract(TimeSpan.FromDays(Day));

        public Scenes.Scene CurrentScene { get; set; }

        /// <summary>
        /// Set all game variables to clean, new-game state.  Used to start a new game,
        /// before loading a saved game, and on loading the game itself.
        /// </summary>
        protected void ResetGame()
        {
            Player = new Player();
            GameTime = new TimeSpan(0, 0, 0, 0);
        }

        /// <summary>
        /// Start a new game.  Resets the game state and loads up the game beginning.
        /// </summary>
        protected void NewGame() { }

        public Game(ISaveLoad saveLoad)
        {
            SaveLoad = saveLoad;
            ResetGame();
            //CurrentScene = new Scenes.MainMenu(this);
            //CurrentScene = new Scenes.CommonScene(this);
            CurrentScene = new Scenes.CombatScene(this);
        }
    }
}
