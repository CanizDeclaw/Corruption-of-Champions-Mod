using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes
{
    public class CombatScene : Scene
    {
        // TODO: Just using a Player for testing.
        public Characters.Creature Opponent { get; }

        public CombatScene(Game game)
            :base(game)
        {
            Opponent = new Characters.Creature();

            // TODO: Remove this test text.
            SceneText =
            @"<FlowDocument xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" FontSize=""18"">
                <Paragraph>
                    <Floater Width=""400"" HorizontalAlignment=""Left"" Margin=""0"">
                        <BlockUIContainer>
                            <Image Source=""/CoC_Desktop_WPF;component/Resources/exclude/monster-goblin_4.jpg""/>
                        </BlockUIContainer>
                    </Floater>
                    <Bold>You are fighting the goblin:</Bold>
                    <LineBreak/>
                    <Run>The goblin before you is a typical example of her species, with dark green skin,
                        pointed ears, and purple hair that would look more at home on a punk-rocker.
                        She’s only about three feet tall, but makes up for it with her curvy body,
                        sporting hips and breasts that would entice any of the men in your village were
                        she full-size. There isn’t a single scrap of clothing on her, just lewd leather
                        straps and a few clinking pouches. She does sport quite a lot of piercings – the
                        most noticeable being large studs hanging from her purple nipples. Her eyes are
                        fiery red, and practically glow with lust. This one isn’t going to be satisfied
                        until she has her way with you. It shouldn’t be too hard to subdue such a little
                        creature, right?</Run>
                </Paragraph>
                <Paragraph>
                    <Run>You see she is in perfect health.</Run>
                </Paragraph>
            </FlowDocument>";
        }
    }
}
