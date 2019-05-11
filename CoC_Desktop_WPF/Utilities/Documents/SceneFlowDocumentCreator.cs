using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoC_Lib.Documents;

namespace CoC_Desktop_WPF.Utilities.Documents
{
    public class SceneFlowDocumentCreator : ISceneDocumentCreator
    {
        protected ImageManager ImageManager;

        public ISceneDocument NewSceneDocument()
        {
            return new SceneFlowDocument(ImageManager);
        }

        public SceneFlowDocumentCreator(ImageManager imageManager)
        {
            ImageManager = imageManager;
        }
    }
}
