using Common_Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Common
{
    public abstract class CoC : Game
    {
        public abstract CoCSettings CoCSettings { get; }
        public abstract CoCLimits CoCLimits { get; }

        public override Settings Settings => CoCSettings;
        public override Limits Limits => CoCLimits;

        public CoC(ISaveLoad saveLoad, Common_Game.Documents.ISceneDocumentCreator sdc)
            :base(saveLoad, sdc)
        {
        }
    }
}
