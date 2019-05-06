using System;
using System.Collections.Generic;
using System.Text;
using CoC_Lib.Commands;

namespace CoC_Lib.Scenes
{
    /// <summary>
    /// This is the the type of scene throughout most of the game.  Camp, NPC interactions, etc.
    /// </summary>
    public class CommonScene : Scene
    {
        // Always-present commands for a CommonScene
        // Not always visible or selectable, though.
        public Command MainMenu;
        public Command Data;
        public Command Stats;
        public Command RankUp;
        public Command Perks;
        public Command Appearance;

        // The rich text (or HTML?) describing the scene and/or its events.
        public object SceneDescription;

        public CommonScene(Game game)
            :base(game)
        { }
    }
}
