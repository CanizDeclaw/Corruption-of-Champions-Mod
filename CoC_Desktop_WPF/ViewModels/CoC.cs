using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoC_Desktop_WPF.ViewModels
{
    public class CoC : BaseVM
    {
        internal readonly CoC_Lib.Game game;
        internal Utilities.ImageManager ImageManager { get; } = new Utilities.ImageManager(@"ImagePack\");

        #region Window variables
        // Scale-with-Window (viewbox) or not
        public bool ScaleWithWindow { get; protected set; } = false;
        public bool DoNotScaleWithWindow => !ScaleWithWindow;

        // Startup Width and Height
        public int ContentWidth => 1210;
        public int ContentHeight => 800;

        // Common View Controls
        public bool CommonMenuVisible => game.CurrentScene.ShowCommonMenu;
        public bool PlayerStatsVisible => game.CurrentScene.ShowPlayerStats;
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
        public bool EnemyStatsVisible => game.CurrentScene.ShowOpponentStats;

        // Main Menu Controls
        public bool MainMenuVisible => game.CurrentScene is CoC_Lib.Scenes.MainMenu;
        #endregion Window variables

        public string VersionText => game.VersionText;

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

        private void OnCommandPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "CurrentScene":
                    OnPropertyChanged("CurrentScene");
                    OnPropertyChanged("CommonMenuVisible");
                    OnPropertyChanged("PlayerStatsVisible");
                    OnPropertyChanged("CharacterSpriteVisible");
                    OnPropertyChanged("SceneDescriptionVisible");
                    OnPropertyChanged("CommonButtonsVisible");
                    OnPropertyChanged("NavigationVisible");
                    OnPropertyChanged("LocationSpriteVisible");
                    OnPropertyChanged("EnemyStatsVisible");
                    OnPropertyChanged("MainMenuVisible");
                    OnPropertyChanged("Player");
                    OnPropertyChanged("Day");
                    OnPropertyChanged("TimeOfDay");
                    break;
                default:
                    break;
            }
        }

        public CoC()
        {
            game = new CoC_Lib.Game(new Utilities.SaveLoadPackage(), new Utilities.Documents.SceneFlowDocumentCreator(ImageManager));
            game.PropertyChanged += OnCommandPropertyChanged;
        }
    }
}
