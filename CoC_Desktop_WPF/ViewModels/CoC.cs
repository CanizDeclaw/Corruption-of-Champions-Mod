using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoC_Desktop_WPF.ViewModels
{
    public class CoC : BaseVM
    {
        internal readonly CoC_Lib.Game game;

        public PlayerVM Player => new PlayerVM(game.Player, this);

        public SceneVM CurrentScene
        {
            get
            {
                switch (game.CurrentScene)
                {
                    case CoC_Lib.Scenes.CombatScene cs:
                        return new Scenes.CombatSceneVM(cs, this);
                    case CoC_Lib.Scenes.CommonScene cs:
                        return new Scenes.CommonSceneVM(cs, this);
                    case CoC_Lib.Scenes.MainMenu mm:
                        return new Scenes.MainMenuVM(mm, this);
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public CoC()
        {
            game = new CoC_Lib.Game(new Utilities.SaveLoadPackage());
        }
    }
}
