using Common_Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Common
{
    public class CoC : Common_Game.Game
    {
        public CoC(Common_Game.ISaveLoad saveLoad, Common_Game.Documents.ISceneDocumentCreator sdc)
            :base(saveLoad, sdc)
        {
        }
    }
}
