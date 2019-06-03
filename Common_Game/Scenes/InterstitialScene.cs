using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Scenes
{
    public class Interstitial : Scene
    {
        protected List<Documents.ISceneDocument> sceneDocuments;

        public Interstitial(Game game, List<Documents.ISceneDocument> sceneDocuments)
            :base(game)
        {
            this.sceneDocuments = sceneDocuments;
            Commands[0] = new Commands.CommonCommands.ContinueCommand(game);
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
