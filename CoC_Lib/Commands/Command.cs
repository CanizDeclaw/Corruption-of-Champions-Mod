using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands
{
    /// <summary>
    /// Base class for all game commands.  Each scene has a list of these, representing what
    /// options a character has in that scene.
    /// 
    /// In a GUI each command should be represented by a button or other object with equivalent semantics.
    /// </summary>
    public abstract class Command
    {
        public abstract string ShortName { get; }
        public abstract string LongName { get; }
        public string Description => CanExecute ? CanExecuteDescription : CanNotExecuteDescription; 
        public abstract string CanExecuteDescription { get; }
        public abstract string CanNotExecuteDescription { get; }

        protected readonly Game Game;
        public abstract bool CanExecute { get; }
        public abstract void Execute();

        public Command(Game game)
        {
            Game = game;
        }
    }
}
