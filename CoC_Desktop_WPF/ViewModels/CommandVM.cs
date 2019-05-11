using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoC_Desktop_WPF.ViewModels
{
    public class CommandVM
    {
        private CoC_Lib.Commands.Command command;

        public string ShortName => command.ShortName;
        public string LongName => command.LongName;
        public string Description => command.Description;
        public bool CanExecute => command.CanExecute;


        public CommandVM(CoC_Lib.Scenes.Scene scene, CoC_Lib.Commands.Command command)
        {
            this.command = command;

            // Register textboxes
            if (command.TextboxKeys.Count > 0)
            {
                var sd = (Utilities.Documents.SceneFlowDocument)scene.SceneDescription;
                var textboxes = sd.Textboxes;
            }
            // Register comboboxes
            if (command.ComboBoxKeys.Count > 0)
            {
                var sd = (Utilities.Documents.SceneFlowDocument)scene.SceneDescription;
                var comboboxes = sd.Comboboxes;
            }
        }
    }
}
