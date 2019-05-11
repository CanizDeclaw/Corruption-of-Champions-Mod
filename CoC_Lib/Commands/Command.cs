using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands
{
    public delegate void TextBoxChangedDelegate(string newText);
    public delegate void ComboBoxSelectionChangedDelegate(string newSelection);
    public delegate void ChangeTextBoxDelegate(string newText);
    public delegate void ChangeComboBoxDelegate(string newSelection);
    /// <summary>
    /// Base class for all game commands.  Each scene has a list of these, representing what
    /// options a character has in that scene.
    /// 
    /// In a GUI each command should be represented by a button or other object with equivalent semantics.
    /// </summary>
    public abstract class Command : NotifyPropertyChangedBase
    {
        protected readonly Game Game;

        public abstract string ShortName { get; }
        public abstract string LongName { get; }
        public string Description => CanExecute ? CanExecuteDescription : CanNotExecuteDescription; 
        public abstract string CanExecuteDescription { get; }
        public abstract string CanNotExecuteDescription { get; }

        public abstract bool CanExecute { get; }
        public abstract void Execute();

        public Dictionary<string, TextBoxChangedDelegate> TextBoxChangedDelegates { get; } = new Dictionary<string, TextBoxChangedDelegate>();
        public Dictionary<string, ComboBoxSelectionChangedDelegate> ComboBoxSelectionChangedDelegates { get; } = new Dictionary<string, ComboBoxSelectionChangedDelegate>();

        public Dictionary<string, ChangeTextBoxDelegate> ChangeTextBoxEvents { get; } = new Dictionary<string, ChangeTextBoxDelegate>();
        public Dictionary<string, ChangeComboBoxDelegate> ChangeComboBoxSelectionEvents { get; } = new Dictionary<string, ChangeComboBoxDelegate>();

        public Command(Game game)
        {
            Game = game;
        }
    }
}
