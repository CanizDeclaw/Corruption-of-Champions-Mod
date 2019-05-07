using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoC_Lib.Scenes;

namespace CoC_Desktop_WPF.ViewModels.Scenes
{
    public class CombatSceneVM : SceneVM
    {
        private readonly CombatScene combatScene;

        public CombatSceneVM(CombatScene cs, CoC game)
            :base(cs, game)
        {
            combatScene = cs;
        }
    }
}
