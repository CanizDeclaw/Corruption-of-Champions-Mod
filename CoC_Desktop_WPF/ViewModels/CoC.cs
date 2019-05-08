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

        #region Window variables
        // Scale-with-Window (viewbox) or not
        public bool UseViewbox { get; protected set; } = true;
        public bool DoNotUseViewbox => !UseViewbox;

        // Common View Controls
        public bool CommonMenuVisible => game.CurrentScene is CoC_Lib.Scenes.CommonScene;
        public bool PlayerStatsVisible
            => game.CurrentScene is CoC_Lib.Scenes.CommonScene
            || game.CurrentScene is CoC_Lib.Scenes.CombatScene;
        public bool CharacterSpriteVisible { get; protected set; } = false;
        public bool SceneDescriptionVisible
            => game.CurrentScene is CoC_Lib.Scenes.CommonScene
            || game.CurrentScene is CoC_Lib.Scenes.CombatScene;
        public bool CommonButtonsVisible
            => game.CurrentScene is CoC_Lib.Scenes.CommonScene
            || game.CurrentScene is CoC_Lib.Scenes.CombatScene;
        public bool NavigationVisible { get; protected set; } = false;
        public bool LocationSpriteVisible { get; protected set; } = false;

        // Combat Controls
        public bool EnemyStatsVisible => game.CurrentScene is CoC_Lib.Scenes.CombatScene;

        // Main Menu Controls
        public bool MainMenuVisible => game.CurrentScene is CoC_Lib.Scenes.MainMenu;
        #endregion Window variables


        public PlayerVM Player => new PlayerVM(game.Player, this);
        public int Day => game.Day;
        public TimeSpan TimeOfDay => game.TimeOfDay;

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
