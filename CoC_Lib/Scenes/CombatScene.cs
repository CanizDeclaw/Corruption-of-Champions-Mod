using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes
{
    // This class is intentionally not derivable.  Combat is managed directly by this class.
    public sealed class CombatScene : Scene
    {
        // TODO: Just using a Player for testing.
        public Creatures.Creature Opponent { get; }

        public CombatScene(Game game, Creatures.Creature Opponent)
            : base(game)
        {
            #region UI Hints
            ShowPlayerStats = true;
            ShowOpponentStats = true;
            ShowCommonMenu = false;
            #endregion UI Hints

            this.Opponent = Opponent;
        }

        protected override void SetDescription() { }

        private void SetTestDescription()
        {
            // TODO: Remove this test text.
            SceneDescription.Clear();
            SceneDescription.NewParagraph();
            SceneDescription.AddFigureImage(@"monster\goblin", Documents.HorizontalAlignment.Left);
            SceneDescription.AddText(@"<b>You are fighting the goblin:</b>");
            SceneDescription.AddLineBreak();
            SceneDescription.AddText(@"
                The goblin before you is a typical example of her species, with dark green skin,
                pointed ears, and purple hair that would look more at home on a punk-rocker.
                She’s only about three feet tall, but makes up for it with her curvy body,
                sporting hips and breasts that would entice any of the men in your village were
                she full-size. There isn’t a single scrap of clothing on her, just lewd leather
                straps and a few clinking pouches. She does sport quite a lot of piercings – the
                most noticeable being large studs hanging from her purple nipples. Her eyes are
                fiery red, and practically glow with lust. This one isn’t going to be satisfied
                until she has her way with you. It shouldn’t be too hard to subdue such a little
                creature, right?");

            SceneDescription.NewParagraph();
            SceneDescription.AddText(@"You see she is in perfect health.");
        }
    }
}
