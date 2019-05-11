using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class CharacterCreationScene : CommonScene
    {
        private readonly string nameBoxKey = "name";

        public CharacterCreationScene(Game game)
            :base(game)
        {
            #region UI Hints
            ShowPlayerStats = false;
            ShowOpponentStats = false;
            ShowCommonMenu = false;
            #endregion UI Hints

            SetDescription();
            Commands[0] = new Commands.SetNameCommand(game, nameBoxKey);
        }

        private void SetDescription()
        {
            SceneDescription.Clear();
            SceneDescription.NewParagraph();
            SceneDescription.AddFigureImage("location/ingnam", Documents.HorizontalAlignment.Left);
            SceneDescription.AddText(
                @"You grew up in the small village of Ingnam, a remote village with rich
                traditions, buried deep in the wilds.  Every year for as long as you can
                remember, your village has chosen a champion to send to the cursed Demon Realm. 
                Legend has it that in years Ingnam has failed to produce a champion, chaos has
                reigned over the countryside.  Children disappear, crops wilt, and disease
                spreads like wildfire.  This year, <b>you</b> have been selected to be the
                champion.");

            SceneDescription.NewParagraph();
            SceneDescription.AddText(@"What is your name? ");
            SceneDescription.AddInputBox(nameBoxKey);
        }
    }
}
