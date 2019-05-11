using CoC_Lib.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation.Commands
{
    class SetNameCommand : Command
    {
        public override string ShortName => "Set Name";
        public override string LongName => "Set Name";
        public override string CanExecuteDescription => $"Set your name to \"{TextBoxContent}\"";
        public override string CanNotExecuteDescription => "Please enter a name into the textbox.";

        public override bool CanExecute => !string.IsNullOrWhiteSpace(TextBoxContent);
        public override void Execute()
        {
            throw new NotImplementedException();
        }

        protected string nameBoxKey;
        protected string comboBoxKey;

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
                _comboBoxSelection = value;
                TextBoxContent = value;
                OnPropertyChanged();
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

        public SetNameCommand(Game game, string nameBoxKey, string comboBoxKey)
            :base(game)
        {
            this.nameBoxKey = nameBoxKey;
            this.comboBoxKey = comboBoxKey;
            TextBoxChangedDelegates.Add(nameBoxKey, OnTextBoxChanged);
            ComboBoxSelectionChangedDelegates.Add(comboBoxKey, OnComboBoxSelectionChanged);
            ChangeTextBoxEvents.Add(nameBoxKey, ChangeTextBoxEvent);
            ChangeComboBoxSelectionEvents.Add(comboBoxKey, ChangeComboBoxEvent);
        }
    }
}
