using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Markup;
using CoC_Lib.Scenes;

namespace CoC_Desktop_WPF.ViewModels.Scenes
{
    public class CombatSceneVM : SceneVM
    {
        private readonly CombatScene combatScene;
        public CreatureVM Opponent { get; }

        // Scene Description
        public FlowDocument SceneText => GetSceneText();
        protected FlowDocument GetSceneText()
        {
            return (FlowDocument)XamlReader.Parse(combatScene.SceneText);
        }

        public CombatSceneVM(CombatScene cs, CoC game)
            :base(cs, game)
        {
            combatScene = cs;
            Opponent = new CreatureVM(cs.Opponent, game);
        }
    }
}
