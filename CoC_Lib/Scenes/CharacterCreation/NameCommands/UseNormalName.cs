using CoC_Lib.Characters.PlayerCharacters;
using CoC_Lib.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class UseNormalName : Command
    {
        public override string ShortName
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(TextBoxContent) && specialCharacters.ContainsKey(TextBoxContent))
                {
                    return "Continue On";
                }
                else
                {
                    return "Set Name";
                }
            }
        }
        public override string LongName => "Set Name";
        public override string CanExecuteDescription
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(TextBoxContent) && specialCharacters.ContainsKey(TextBoxContent))
                {
                    return $"Set your name to \"{TextBoxContent}\", safe in the knowledge there's absolutely nothing special about you at all.  Yet.";
                }
                else
                {
                    return $"Set your name to \"{TextBoxContent}\".";
                }
            }
        }
        public override string CanNotExecuteDescription => "Please enter a name into the textbox.";

        public override bool CanExecute => !string.IsNullOrWhiteSpace(TextBoxContent);
        public override void Execute()
        {
            var player = new Characters.Player() { Name = TextBoxContent };
            Game.Player = player;
            Game.PushScene(new ChooseSex(Game));
            Game.NextScene();
        }

        protected string nameBoxKey;
        protected string comboBoxKey;
        protected readonly Dictionary<string, SpecialPlayerCharacter> specialCharacters;

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
                    OnPropertyChanged("ShortName");
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

        public UseNormalName(Game game, Dictionary<string, SpecialPlayerCharacter> specialCharacters, string nameBoxKey, string comboBoxKey)
            :base(game)
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
