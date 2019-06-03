using CoC_Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_UEE
{
    class CoC_UEE : CoC
    {
        public CoC_UEE(Common_Game.ISaveLoad saveLoad, Common_Game.Documents.ISceneDocumentCreator sdc)
            : base(saveLoad, sdc)
        {
        }
    }
}
