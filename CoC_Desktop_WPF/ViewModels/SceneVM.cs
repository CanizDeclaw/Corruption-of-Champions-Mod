using CoC_Desktop_WPF.Utilities;
using System.Linq;
using System.Windows.Documents;

namespace CoC_Desktop_WPF.ViewModels
{
    public abstract class SceneVM : BaseVM
    {
        public CoC Game { get; }
        public CommandVM[] Commands { get; }

        public SceneVM(CoC_Lib.Scenes.Scene scene, CoC game)
        {
            Game = game;

            Commands = scene.Commands
                .Select(c => c == null ? null : new CommandVM(scene, c))
                .ToArray();
        }
    }
}