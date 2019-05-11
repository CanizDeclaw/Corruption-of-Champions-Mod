using System;
using System.Collections.Generic;
using System.Text;
using CoC_Lib.Commands;

namespace CoC_Lib.Scenes
{
    /// <summary>
    /// Abstract base class for all scene classes.
    /// </summary>
    public abstract class Scene
    {
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

        public Game Game { get; }

        /// <summary>
        /// The rich text (or HTML?) describing the scene and/or its events.
        /// </summary>
        public Documents.ISceneDocument SceneDescription { get; }

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
            Game = game;
            SceneDescription = Game.SceneDocumentCreator.NewSceneDocument();
        }
    }
}
