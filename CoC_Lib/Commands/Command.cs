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
    public class Command
    {
        public string ShortName;
        public string Description => CanExecute(game) ? CanExecuteDescription : CanNotExecuteDescription; 
        public string CanExecuteDescription;
        public string CanNotExecuteDescription;

        protected readonly Game game;
        public Func<Game, bool> CanExecute;
        public Action<Game> NextScene;
    }
}
