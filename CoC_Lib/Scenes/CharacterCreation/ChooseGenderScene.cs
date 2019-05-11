using CoC_Lib.Flags.GameFlags.NewGamePlus;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    public class ChooseGenderScene : CommonScene
    {
        public ChooseGenderScene(Game game)
            :base(game)
        {
            SetDescription();
            Commands[0] = new ChooseManCommand(game);
            Commands[1] = new ChooseWomanCommand(game);
            Commands[2] = new ChooseHermCommand(game);

        }

        protected override void SetDescription()
        {
            var unlockedHerm = Game.GameFlags.ContainsKey(new UnlockedHerm().Key);
            SceneDescription.AddParagraph(@"Are you a man or a woman?");

            if (unlockedHerm)
            {
                SceneDescription.AddParagraph(@"Or a hermaphrodite, as you've unlocked the hermaphrodite option?");
            }
        }
    }
}
