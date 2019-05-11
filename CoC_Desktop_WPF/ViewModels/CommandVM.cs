using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace CoC_Desktop_WPF.ViewModels
{
    public class CommandVM : BaseVM, ICommand
    {
        private CoC_Lib.Commands.Command command;

        public string ShortName => command.ShortName;
        public string LongName => command.LongName;
        public string Description => command.Description;
        public bool CanExecute => command.CanExecute;


        public CommandVM(CoC_Lib.Scenes.Scene scene, CoC_Lib.Commands.Command command)
        {
            this.command = command;
            RegisterInputListeners(scene, command);
            command.PropertyChanged += OnCommandPropertyChanged;
        }

        private void OnCommandPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "ShortName":
                    OnPropertyChanged("ShortName");
                    break;
                case "LongName":
                    OnPropertyChanged("LongName");
                    break;
                case "Description":
                    OnPropertyChanged("Description");
                    break;
                case "CanExecute":
                    OnPropertyChanged("CanExecute");
                    CanExecuteChanged?.Invoke(this, new EventArgs());
                    break;
                default:
                    break;
            }
        }

        private void RegisterInputListeners(CoC_Lib.Scenes.Scene scene, CoC_Lib.Commands.Command command)
        {
            // Register textbox delegates
            if (command.TextBoxChangedDelegates.Count > 0)
            {
                var sd = (Utilities.Documents.SceneFlowDocument)scene.SceneDescription;
                var textboxes = sd.Textboxes;
                foreach (var key in command.TextBoxChangedDelegates.Keys)
                {
                    var textbox = textboxes[key];
                    if (textbox != null)
                    {
                        textbox.TextChanged += (sender, args) =>
                        {
                            if (sender is TextBox tbox)
                            {
                                command.TextBoxChangedDelegates[key]?.Invoke(tbox.Text);
                            }
                        };
                    }
                }
            }
            if (command.ChangeTextBoxEvents.Count > 0)
            {
                var sd = (Utilities.Documents.SceneFlowDocument)scene.SceneDescription;
                var textboxes = sd.Textboxes;
                foreach (var key in command.ChangeTextBoxEvents.Keys.ToList())
                {
                    var textbox = textboxes[key];
                    if (textbox != null)
                    {
                        command.ChangeTextBoxEvents[key] += (string text) =>
                        {
                            textbox.Text = text;
                        };
                    }
                }
            }
            // Register combobox delegates
            if (command.ComboBoxSelectionChangedDelegates.Count > 0)
            {
                var sd = (Utilities.Documents.SceneFlowDocument)scene.SceneDescription;
                var comboboxes = sd.Comboboxes;
                foreach (var key in command.ComboBoxSelectionChangedDelegates.Keys)
                {
                    var combobox = comboboxes[key];
                    if (combobox != null)
                    {
                        combobox.SelectionChanged += (sender, args) =>
                        {
                            if (sender is ComboBox cbox)
                            {
                                command.ComboBoxSelectionChangedDelegates[key]?.Invoke((string)cbox.SelectedItem);
                            }
                        };
                    }
                }
            }
            if (command.ChangeComboBoxSelectionEvents.Count > 0)
            {
                var sd = (Utilities.Documents.SceneFlowDocument)scene.SceneDescription;
                var comboboxes = sd.Comboboxes;
                foreach (var key in command.ChangeComboBoxSelectionEvents.Keys.ToList())
                {
                    var combobox = comboboxes[key];
                    if (combobox != null)
                    {
                        command.ChangeComboBoxSelectionEvents[key] += (string text) =>
                        {
                            combobox.SelectedItem = text;
                        };
                    }
                }
            }
        }

        public event EventHandler CanExecuteChanged;

        bool ICommand.CanExecute(object parameter) => command.CanExecute;

        void ICommand.Execute(object parameter) => command.Execute();
    }
}
