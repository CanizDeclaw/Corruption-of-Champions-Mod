using CoC_Common;
using Common_Game;
using Common_Game.Creatures;
using Common_Game.Scenes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_UEE
{
    class CoC_UEE : CoC
    {
        public CoC_UEE_Settings UEE_Settings { get; protected set; }
        public CoC_UEE_Limits UEE_Limits { get; protected set; }

        public override CoCSettings CoCSettings => UEE_Settings;
        public override CoCLimits CoCLimits => UEE_Limits;

        public CoC_UEE(Common_Game.ISaveLoad saveLoad, Common_Game.Documents.ISceneDocumentCreator sdc)
            : base(saveLoad, sdc)
        {
        }

        protected override Player NewPlayer(Game game)
        {
            throw new NotImplementedException();
        }

        protected override Scene NewGameScene(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
