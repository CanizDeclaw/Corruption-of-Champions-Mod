using CoC_Lib.Flags.GameFlags.NewGamePlus;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    public class ChooseSex : CommonScene
    {
        protected bool unlockedHerm;

        public ChooseSex(Game game)
            :base(game)
        {
            SetDescription();
            Commands[0] = new Man(game);
            Commands[1] = new Woman(game);
            if (unlockedHerm)
            {
                Commands[2] = new Herm(game);
            }
        }

        protected override void SetDescription()
        {
            unlockedHerm = Game.GameFlags.ContainsKey(UnlockedHerm.Key);
            SceneDescription.AddParagraph(@"Are you a man or a woman?");

            if (unlockedHerm)
            {
                SceneDescription.AddParagraph(@"Or a hermaphrodite, as you've unlocked the hermaphrodite option?");
            }
        }
    }
}
