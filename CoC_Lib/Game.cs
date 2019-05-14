﻿using CoC_Lib.Creatures;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CoC_Lib
{
    public class Game : NotifyPropertyChangedBase
    {
        #region Dev variables & properties to be properly sorted out
        public string VersionText => "1.0.2_mod_2.0.0-alpha (C# Port), Dev Build";
        #endregion Dev variables & properties to be properly sorted out

        #region Public API
        public Game(ISaveLoad saveLoad, Documents.ISceneDocumentCreator sdc)
        {
            SaveLoad = saveLoad;
            SceneDocumentCreator = sdc;

            GameFlags = new Dictionary<string, Flags.GameFlag>();

            ResetGame();
            CurrentScene = new Scenes.MainMenu(this);
            //CurrentScene = new Scenes.CommonScene(this);
            //CurrentScene = new Scenes.CombatScene(this);
            //CurrentScene = new Scenes.CharacterCreation.CharacterCreationScene(this);
        }

        #region Game properties
        // Game State
        private bool _inProgress;
        public bool InProgress
        {
            get => _inProgress;
            set
            {
                _inProgress = value;
                OnPropertyChanged();
            }
        }
        // Game Time
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
                if (InProgress == false && value != null)
                {
                    InProgress = true;
                }
                else if (value == null & InProgress == true)
                {
                    InProgress = false;
                }
                OnPropertyChanged();
            }
        }

        public Dictionary<string, Flags.GameFlag> GameFlags;

        // Current scene
        private Scenes.Scene _currentScene;
        public Scenes.Scene CurrentScene
        {
            get => _currentScene;
            protected set
            {
                _currentScene = value;
                OnPropertyChanged("CurrentScene");
            }
        }
        #endregion Game properties
        #endregion Public API

        #region Internal API
        // Utilities
        internal ISaveLoad SaveLoad;
        internal Documents.ISceneDocumentCreator SceneDocumentCreator;

        // Settings
        internal CoCSettings Settings = new CoCSettings();
        internal CoCLimits Limits = new CoCLimits();

        // Scene Management
        internal Scenes.Scene HomeScene { get; set; }
        internal Scenes.Interstitial InterstitialScene { get; set; }
        protected Stack<Scenes.Scene> SceneStack = new Stack<Scenes.Scene>();
        internal void PushScene(Scenes.Scene scene)
        {
            SceneStack.Push(scene);
        }
        internal void NextScene()
        {
            if (SceneStack.Count > 0)
            {
                var next = SceneStack.Pop();
                next.Run();
                CurrentScene = next;
            }
            else
            {
                if (InProgress)
                {
                    // Clock ticks only registered at HomeScene, to prevent interrupting other ones.
                    // TODO: change this to be a bit more general and customizable.
                    ClockChanged?.Invoke(GameTime);
                }
                var next = HomeScene;
                next.Run();
                CurrentScene = next;
            }
        }

        // Game Management
        internal delegate void TimeAwareDelegate(TimeSpan currentTime);
        internal delegate Documents.ISceneDocument TimeAwareWithDescriptionDelegate(TimeSpan currentTime);
        // TODO: Do this in a way that allows output, and that works with sleep-wakes.
        internal event TimeAwareDelegate ClockChanged;

        /// <summary>
        /// Set all game variables to clean, new-game state.  Used to start a new game,
        /// before loading a saved game, and on loading the game itself.
        /// </summary>
        internal void ResetGame()
        {
            Player = new Player();
            GameTime = new TimeSpan(0, 0, 0, 0);
            InProgress = false;
        }

        /// <summary>
        /// Start a new game.  Resets the game state and loads up character creation.
        /// </summary>
        internal void NewGame()
        {
            ResetGame();
            CurrentScene = new Scenes.CharacterCreation.BeginCharacterCreation(this);
        }
        /// <summary>
        /// Start a new game, with bonuses from the past.  Resets the game state and loads up character creation.
        /// </summary>
        internal void NewGamePlus()
        {
            ResetGame();
            CurrentScene = new Scenes.CharacterCreation.BeginCharacterCreation(this);
            throw new NotImplementedException();
        }
        #endregion Internal API
    }
}
