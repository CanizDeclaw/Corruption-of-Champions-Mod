using CoC_Lib.Commands;

namespace CoC_Lib.Scenes.CharacterCreation
{
    internal class SetHeight : Command
    {
        // TODO: Units (Imperial/Metric)
        public override string ShortName => "Set Height";
        public override string LongName => "Set Height";
        public override string CanExecuteDescription => $"Set your height to {TextBoxContent} inches.";
        public override string CanNotExecuteDescription => "Please enter a valid height into the textbox.";

        public override bool CanExecute => IsValidHeight(TextBoxContent);
        public override void Execute()
        {
            if (int.TryParse(TextBoxContent, out int height))
            {
                if (IsValidHeight(height))
                {
                    Game.Player.Height = height;
                    Game.NextScene();
                }
            }
        }

        protected string heightBoxKey;

        protected string _textBoxContent;
        protected string TextBoxContent
        {
            get => _textBoxContent;
            set
            {
                if (value != _textBoxContent)
                {
                    if (string.IsNullOrEmpty(value) || IsValidPotentialHeight(value))
                    {
                        _textBoxContent = value;
                    }
                    OnPropertyChanged();
                    OnPropertyChanged("CanExecute");
                    OnPropertyChanged("Description");
                    ChangeTextBoxEvents[heightBoxKey]?.Invoke(_textBoxContent);
                }
            }
        }

        protected void OnTextBoxChanged(string newText)
        {
            TextBoxContent = newText;
        }
        public event ChangeTextBoxDelegate ChangeTextBoxEvent;

        protected bool IsValidPotentialHeight(string s)
        {
            if (int.TryParse(s, out int height))
            {
                if (height > 0 && height <= 96)
                {
                    return true;
                }
            }
            return false;
        }
        protected bool IsValidHeight(string s)
        {
            if (int.TryParse(s, out int height))
            {
                return IsValidHeight(height);
            }
            return false;
        }
        protected bool IsValidHeight(int height)
        {
            if (height >= 48 && height <= 96)
            {
                return true;
            }
            return false;
        }

        public SetHeight(Game game, string heightBoxKey)
            : base(game)
        {
            this.heightBoxKey = heightBoxKey;
            TextBoxChangedDelegates.Add(this.heightBoxKey, this.OnTextBoxChanged);
            ChangeTextBoxEvents.Add(this.heightBoxKey, ChangeTextBoxEvent);
        }
    }
}