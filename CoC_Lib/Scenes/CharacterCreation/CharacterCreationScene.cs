using System;
using System.Collections.Generic;
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

            SetDescription();
            Commands[0] = new Commands.SetNameCommand(game, nameBoxKey, comboBoxKey);
            Commands[0].ChangeTextBoxEvents[nameBoxKey] += (string name) => UpdateSpecialCharDescription(name);
            specialCharacters = new SpecialCharacters(game).GetSpecialCharactersDictionary();
        }

        private void UpdateSpecialCharDescription(string name)
        {
            Documents.ISceneDocument section;
            if (specialCharacters.ContainsKey(name))
            {
                section = specialCharacters[name].Description;
            }
            else
            {
                section = Game.SceneDocumentCreator.NewSceneDocument();
                section.AddParagraph("");
            }
            SceneDescription.MutateSection(specialCharDescKey, section.Description);
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
            SceneDescription.AddComboBox(GetSpecialCharacterNames(), comboBoxKey);
            SceneDescription.AddMutableSection(specialCharDescKey);
        }

        private List<string> GetSpecialCharacterNames()
        {
            return new List<string>()
            {
                "Without pre-defined history:",
                "Aria",
                "Bertram",
                "Charaun",
                "Cody",
                "Galatea",
                "Gundam",
                "Hikari",
                "Katti",
                "Lucina",
                "Navorn",
                "Rope",
                "Sora",
                "With pre-defined history:",
                "Annetta",
                "Ceveo",
                "Charlie",
                "Chimera",
                "Etis",
                "Isaac",
                "Leah",
                "Lukaz",
                "Mara",
                "Mihari",
                "Mirvanna",
                "Nami",
                "Nixi",
                "Prismere",
                "Rann Rayla",
                "Sera",
                "Siveen",
                "Tyriana",
                "Vahdunbrii",
            };
        }
    }
}
