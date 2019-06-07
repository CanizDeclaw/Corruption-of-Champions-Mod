using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Scenes
{
    class HistoryScene : Scene
    {
        public override TimeSpan ElapsedTime
        {
            get => throw new NotImplementedException();
            protected set => throw new NotImplementedException();
        }

        // Need to make a history manager to deal with all of this?
        // Make sure scenes can link forward without having to have all scene instantiated.
        public HistoryScene(Game game, Documents.ISceneDocument scene)
            :base(game)
        {

        }

        public override void Run()
        {
            throw new NotImplementedException();
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
