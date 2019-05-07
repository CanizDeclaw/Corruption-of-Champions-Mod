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


        public CommandVM(CoC_Lib.Commands.Command command)
        {
            this.command = command;
        }
    }
}
