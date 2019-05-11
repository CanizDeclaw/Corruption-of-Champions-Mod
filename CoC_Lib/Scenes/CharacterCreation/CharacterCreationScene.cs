using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class CharacterCreationScene : CommonScene
    {
        private readonly string nameBoxKey = "name";
        private readonly string comboBoxKey = "specialNames";
        private readonly string specialCharDescKey = "specialCharDescription";
        private readonly Dictionary<string, SpecialCharacter> specialCharacters;

        public CharacterCreationScene(Game game)
            : base(game)
        {
            #region UI Hints
            ShowPlayerStats = false;
            ShowOpponentStats = false;
            ShowCommonMenu = false;
            #endregion UI Hints

            specialCharacters = new SpecialCharacters(game).GetSpecialCharactersDictionary();
            Commands[0] = new Commands.SetNameCommand(game, specialCharacters, nameBoxKey, comboBoxKey);
            Commands[0].ChangeTextBoxEvents[nameBoxKey] += (string name) => UpdateSpecialCharDescription(name); // We only need this once.
            Commands[1] = new Commands.UseSpecialName(game, specialCharacters, nameBoxKey, comboBoxKey);
            SetDescription();
        }

        private void UpdateSpecialCharDescription(string name)
        {
            var section = Game.SceneDocumentCreator.NewSceneDocument();
            section.AddHeader(name);
            if (specialCharacters.ContainsKey(name))
            {
                section.AddSection(specialCharacters[name].Description);
                if (specialCharacters[name].SkipCustomization)
                {
                    section.AddParagraph(@"This character is pre-customized, and customization will be skipped if you choose ""SpecialName""");
                }
                else
                {
                    section.AddParagraph(@"This character, while having some peculiar differences from the norm, will still be customizable if you choose ""SpecialName"".");
                }
            }
            else
            {
                section.AddParagraph("You're a fairly normal person, really.");
            }
            SceneDescription.MutateSection(specialCharDescKey, section.Description);
        }

        protected override void SetDescription()
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
            SceneDescription.AddComboBox(GetSpecialCharacterNames(), comboBoxKey);
            SceneDescription.AddMutableSection(specialCharDescKey);
        }

        private List<string> GetSpecialCharacterNames()
        {
            return specialCharacters.Keys.ToList();
        }
    }
}
