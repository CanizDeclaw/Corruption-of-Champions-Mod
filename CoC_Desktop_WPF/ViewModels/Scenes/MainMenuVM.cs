using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoC_Lib.Scenes;

namespace CoC_Desktop_WPF.ViewModels.Scenes
{
    public class MainMenuVM : SceneVM
    {
        private readonly MainMenu mainMenu;

        public MainMenuVM(MainMenu mm, CoC game)
            :base(mm, game)
        {
            mainMenu = mm;
        }
    }
}
