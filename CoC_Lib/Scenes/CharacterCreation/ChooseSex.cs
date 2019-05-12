using CoC_Lib.Flags.GameFlags.NewGamePlus;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    public class ChooseSex : CommonScene
    {
        protected bool UnlockedHerm;

        public ChooseSex(Game game)
            :base(game)
        {
            SetDescription();
            Commands[0] = new Man(game);
            Commands[1] = new Woman(game);
            if (UnlockedHerm)
            {
                Commands[2] = new Herm(game);
            }
        }

        protected override void SetDescription()
        {
            UnlockedHerm = Game.GameFlags.ContainsKey(new UnlockedHerm().Key);
            SceneDescription.AddParagraph(@"Are you a man or a woman?");

            if (UnlockedHerm)
            {
                SceneDescription.AddParagraph(@"Or a hermaphrodite, as you've unlocked the hermaphrodite option?");
            }
        }
    }
}
