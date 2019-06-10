using System;
using System.Collections.Generic;
using System.Text;
using Common_Game.Commands;

// TODO: Add History menu item to common menu
namespace Common_Game.Scenes
{
    /// <summary>
    /// Abstract base class for all scene classes.
    /// </summary>
    public abstract class Scene : NotifyPropertyChangedBase
    {
        // TODO: Replace with derivable UIHints class?
        #region UI Hints
        /// <summary>
        /// Whether or not the player's stats should be shown.
        /// </summary>
        public bool ShowPlayerStats { get; protected set; } = false;
        /// <summary>
        /// Whether or not an opponents (if any) stats should be shown.
        /// </summary>
        public bool ShowOpponentStats { get; protected set; } = false;
        /// <summary>
        /// Whether or not the common menu is usable in this scene.  Defaults to false.
        /// </summary>
        public bool ShowCommonMenu { get; protected set; } = false;
        #endregion UI Hints

        protected readonly Game game;
        public abstract bool IncludeInHistory { get; }

        public abstract TimeSpan ElapsedTime { get; protected set; }

        protected Documents.ISceneDocument _sceneDescription;
        /// <summary>
        /// The rich text (or HTML?) describing the scene and/or its events.
        /// </summary>
        public Documents.ISceneDocument SceneDescription
        {
            // TODO: Might have to put this back to get-only to avoid accidental multi-description IncludeInHistory scenes.
            // Or just prevent setting if IncludeInHistory is true and _sceneDescription is not null.
            // But how to deal with scenes with mutable sections?
            // SceneDocument probably needs a "getHistoryDescription" property.
            get => _sceneDescription;
            protected set
            {
                _sceneDescription = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Each scene has a max of 15 non-default action choices, not including the static(-ish)
        /// choices like "Main Menu" and "Appearance".  Scenes are not guaranteed to use all
        /// slots, nor to use them sequentially.
        /// 
        /// In a GUI these should probably be layed out as 3 rows of 5 buttons each.
        /// </summary>
        public Command[] Commands { get; } = new Command[15];

        public Scene(Game game)
        {
            this.game = game;
            SceneDescription = game.SceneDocumentCreator.NewSceneDocument();
        }

        /// <summary>
        /// Get the HistoryItems from this scene to add to the History.
        /// </summary>
        /// <returns>A list of HistoryItems, or null if none should be added.</returns>
        public abstract List<HistoryItem> GetHistoryItems();

        /// <summary>
        /// Game state may change between when a scene is created and when it's time to view it,
        /// so any prep work that depends on game state should be executed inside this function, which
        /// will be called when a scene is popped into CurrentScene.
        /// </summary>
        public abstract void Run();
        /// <summary>
        /// Set the scene description.  This should *NOT* be called by base classes, as derived
        /// classes may need to set up special IO or load data in their constructors.
        /// </summary>
        protected abstract void SetDescription();
    }
}
