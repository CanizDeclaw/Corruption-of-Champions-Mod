using Common_Game.Creatures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Common_Game
{
    public abstract class Game : NotifyPropertyChangedBase
    {
        // TODO: This is temporary until a proper mechanism is implemented.
        public virtual string VersionText => "1.0.2_mod_2.0.0-alpha (C# Port), Dev Build";

        // Utilities
        internal ISaveLoad SaveLoad;
        internal Documents.ISceneDocumentCreator SceneDocumentCreator;

        // Settings
        public abstract Settings Settings { get; }
        public abstract Limits Limits { get; }

        // Registries
        public Registries.Registry<Items.Item> ItemRegistry { get; }
        public Registries.Registry<Perks.Perk> PerkRegistry { get; }
        public Registries.Registry<Flags.GameFlag> GameFlagRegistry { get; }
        public Registries.Registry<Flags.PlayerFlag> PlayerFlagRegistry { get; }
        public Registries.Registry<Scenes.Scene> SceneRegistry { get; } // Just need to register the entry to a scene.
        // NPC registry
        public Registries.Registry<Character> NpcRegistry { get; }
        // Pre-Made PCs registry
        public Registries.Registry<Player> PcRegistry { get; }

        // Game State
        public Dictionary<string, Flags.GameFlag> GameFlags;

        public SceneManager SceneManager { get; }

        public TimeSpan GameTime { get; internal set; }
        public int Day => GameTime.Days;
        public TimeSpan TimeOfDay => GameTime.Subtract(TimeSpan.FromDays(Day));

        // Player
        private Player _player;
        public Player Player
        {
            get => _player;
            internal set
            {
                _player = value;
                OnPropertyChanged();
            }
        }

        public Dictionary<string, Character> NPCs { get; protected set; }

        public Game(ISaveLoad saveLoad, Documents.ISceneDocumentCreator sdc)
        {
            SaveLoad = saveLoad;
            SceneDocumentCreator = sdc;

            GameFlags = new Dictionary<string, Flags.GameFlag>();

            SceneManager = new SceneManager(this);

            ResetGame();
            SceneManager.PushScene(Settings.DefaultHomeScene);
            //SceneManager.PushScene(new Scenes.MainMenu(this));
            //SceneManager.PushScene(new Scenes.CommonScene(this));
            //SceneManager.PushScene(new Scenes.CombatScene(this));
            //SceneManager.PushScene(NewGameScene(this));
            SceneManager.NextScene();
        }

        /* Time-aware events.
         * Please note that events are responsible for removing themselves.
         */
        public delegate void TimeAwareDelegate(TimeSpan currentTime);
        public delegate Documents.ISceneDocument TimeAwareReturnsDescriptionDelegate(TimeSpan currentTime);
        public delegate Scenes.Scene TimeAwareReturnsSceneDelegate(TimeSpan currentTime);
        public event TimeAwareDelegate OnClockChanged;
        public event TimeAwareReturnsDescriptionDelegate OnClockChangedReturnsDescription;
        public event TimeAwareReturnsSceneDelegate OnClockChangedReturnsScene;

        // Methods for resetting game state
        protected internal abstract Player NewPlayer(Game game);
        protected internal abstract Scenes.Scene NewGameScene(Game game);

        /// <summary>
        /// Set all game variables to clean, new-game state.  Used to start a new game,
        /// before loading a saved game, and on loading the game itself.
        /// </summary>
        protected internal void ResetGame()
        {
            Player = NewPlayer(this);
            // Reset Flags
            // Reset NPCs
            // Reset Regions
            // Reset ALL the things!
            GameTime = new TimeSpan(0, 0, 0, 0);
            OnClockChanged = null;
            OnClockChangedReturnsDescription = null;
            OnClockChangedReturnsScene = null;

            SceneManager.Reset();
            // Clock ticks only registered at HomeScene, to prevent interrupting other ones.
            SceneManager.OnGotoHomeScene += new Action(OnGotoHomeScene);
        }

        /// <summary>
        /// Start a new game.  Resets the game state and loads up character creation.
        /// </summary>
        protected internal void NewGame()
        {
            ResetGame();
            SceneManager.PushScene(NewGameScene(this));
        }
        /// <summary>
        /// Start a new game, with bonuses from the past.  Resets the game state and loads up character creation.
        /// </summary>
        protected internal void NewGamePlus()
        {
            ResetGame();
            SceneManager.PushScene(NewGameScene(this));
            throw new NotImplementedException();
        }

        private void OnChangeScene()
        {
            throw new NotImplementedException();
        }

        private void OnGotoHomeScene()
        {
            OnClockChanged?.Invoke(GameTime);
            if (OnClockChangedReturnsDescription != null)
            {
                var documents = new List<Documents.ISceneDocument>();
                foreach (TimeAwareReturnsDescriptionDelegate item in OnClockChangedReturnsDescription.GetInvocationList())
                {
                    documents.Add(item(GameTime));
                }
                var scene = new Scenes.Interstitial(this, documents);
                SceneManager.PushScene(scene);
            }
            else if (OnClockChangedReturnsScene != null)
            {
                var next = (TimeAwareReturnsSceneDelegate)OnClockChangedReturnsScene.GetInvocationList().First();
                SceneManager.PushScene(next(GameTime));
            }
        }
    }
}
