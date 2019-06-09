using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Commands
{
    public class GenericCommand : Command
    {
        public string shortName { get; set; }
        public override string ShortName => shortName;
        public string longName { get; set; }
        public override string LongName => longName;
        public string canExecuteDescription { get; set; }
        public override string CanExecuteDescription => canExecuteDescription;
        public string canNotExecuteDescription { get; set; }
        public override string CanNotExecuteDescription => canNotExecuteDescription;

        public Func<bool> canExecute { get; set; }
        public override bool CanExecute => canExecute?.Invoke() ?? false;

        public Action execute { get; set; }
        public override void Execute()
        {
            execute?.Invoke();
        }

        public GenericCommand(Game game)
            :base(game)
        { }
    }
}
