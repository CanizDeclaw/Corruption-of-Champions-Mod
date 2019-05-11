using CoC_Lib.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class UseSpecialName : Command
    {
        public override string ShortName => "SpecialName";
        public override string LongName => "Use this special name.";
        public override string CanExecuteDescription => $"This name, like you, is special. Do you choose to live up to your name?  Or will you continue on, assuming it to be coincidence?";
        public override string CanNotExecuteDescription => "Please choose or type a special name.";

        public override bool CanExecute => TextBoxContent != null && specialCharacters.ContainsKey(TextBoxContent);
        public override void Execute()
        {
            var player = new Characters.Player() { Name = TextBoxContent };
            Game.Player = player;
        }

        protected string nameBoxKey;
        protected string comboBoxKey;
        protected readonly Dictionary<string, SpecialCharacter> specialCharacters;

        protected string _textBoxContent;
        protected string TextBoxContent
        {
            get => _textBoxContent;
            set
            {
                if (value != _textBoxContent)
                {
                    _textBoxContent = value;
                    OnPropertyChanged();
                    OnPropertyChanged("CanExecute");
                    OnPropertyChanged("Description");
                    ChangeTextBoxEvents[nameBoxKey]?.Invoke(value);
                    ChangeComboBoxSelectionEvents[comboBoxKey]?.Invoke(value);
                }
            }
        }
        protected string _comboBoxSelection;
        protected string ComboBoxSelection
        {
            get => _comboBoxSelection;
            set
            {
                if (_comboBoxSelection != value)
                {
                    _comboBoxSelection = value;
                    TextBoxContent = value;
                    OnPropertyChanged();
                }
            }
        }

        protected void OnTextBoxChanged(string newText)
        {
            TextBoxContent = newText;
        }
        protected void OnComboBoxSelectionChanged(string newSelection)
        {
            ComboBoxSelection = newSelection;
        }
        public event ChangeTextBoxDelegate ChangeTextBoxEvent;
        public event ChangeComboBoxDelegate ChangeComboBoxEvent;

        public UseSpecialName(Game game, Dictionary<string, SpecialCharacter> specialCharacters, string nameBoxKey, string comboBoxKey)
            : base(game)
        {
            this.specialCharacters = specialCharacters;
            this.nameBoxKey = nameBoxKey;
            this.comboBoxKey = comboBoxKey;
            TextBoxChangedDelegates.Add(nameBoxKey, OnTextBoxChanged);
            ComboBoxSelectionChangedDelegates.Add(comboBoxKey, OnComboBoxSelectionChanged);
            ChangeTextBoxEvents.Add(nameBoxKey, ChangeTextBoxEvent);
            ChangeComboBoxSelectionEvents.Add(comboBoxKey, ChangeComboBoxEvent);
        }
    }
}
