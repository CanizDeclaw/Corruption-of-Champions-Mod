using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands
{
    /// <summary>
    /// Base class for all game commands.  Each scene has a list of these, representing what
    /// options a character has in that scene. Can be instantiated directly for one-off commands
    /// or derived from for common ones.
    /// 
    /// In a GUI each command represents a button.
    /// </summary>
    public abstract class Command
    {
        public abstract string ShortName { get; }
        public string Description => CanExecute(Game) ? CanExecuteDescription : CanNotExecuteDescription; 
        public abstract string CanExecuteDescription { get; }
        public abstract string CanNotExecuteDescription { get; }

        protected readonly Game Game;
        public abstract Func<Game, bool> CanExecute { get; }
        public abstract Action<Game> NextScene { get; }

        public Command(Game game)
        {
            Game = game;
        }
    }
}
