using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.GenericScenes
{
    public class ItemConsumptionScene : CommonScene
    {
        public ItemConsumptionScene(Game game, Documents.ISceneDocument sceneText)
            :base(game)
        {
            SceneDescription.AddSection(sceneText);
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
