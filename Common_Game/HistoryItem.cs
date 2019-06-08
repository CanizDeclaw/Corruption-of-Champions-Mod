using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Common_Game.Scenes;

namespace Common_Game
{
    public class HistoryItem
    {
        public Documents.ISceneDocument SceneDescription { get; }

        public HistoryItem(Documents.ISceneDocument sceneDocument)
        {
            SceneDescription = sceneDocument;
        }
    }
}
