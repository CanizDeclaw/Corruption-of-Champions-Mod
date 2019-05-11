using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    // TODO: This should be replaced with special character registration?
    // At the least, the characters should be moved to the `Characters` name space, in separate files.
    internal class SpecialCharacters
    {
        protected Game Game;

        internal List<SpecialCharacter> GetSpecialCharactersList() => new List<SpecialCharacter>()
        {
            new SpecialCharacter() {
                Name = "Without pre-defined history:",
                SkipCustomization = false,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("")},
            new SpecialCharacter() {
                Name = "Aria",
                SkipCustomization = false,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("It's really no surprise that you were sent through the portal to deal with the demons - you look enough like one as-is.  Your numerous fetish-inducing piercings, magical fox-tails, and bimbo-licious personality were all the motivation the elders needed to keep you from corrupting the village youth.")},
            new SpecialCharacter() {
                Name = "Betram",
                SkipCustomization = false,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("You're quite the foxy herm, and as different as you were compared to the rest of Ingnam, it's no surprise you were sent through first.")},
            new SpecialCharacter() {
                Name = "Charaun",
                SkipCustomization = false,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("As a gifted fox with a juicy, thick knot, a wet cunt, and magical powers, you have no problems with being chosen as champion.")},
            new SpecialCharacter() {
                Name = "Cody",
                SkipCustomization = false,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("Your orange and black tiger stripes make you cut a more imposing visage than normal, and with your great strength, armor, and claymore, you're a natural pick for champion.")},
            new SpecialCharacter() {
                Name = "Galatea",
                SkipCustomization = false,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("You've got large breasts prone to lactation.  You aren't sure WHY you got chosen as a champion, but with your considerable strength, you're sure you'll do a good job protecting Ingnam.")},
            new SpecialCharacter() {
                Name = "Gundam",
                SkipCustomization = false,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("You're fabulously rich, thanks to a rather well-placed bet on who would be the champion.  Hopefully you can buy yourself out of any trouble you might get in.")},
            new SpecialCharacter() {
                Name = "Hikari",
                SkipCustomization = false,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("As a herm with a super-thick cat-cock, D-cup breasts, and out-of-this-world armor, you're a natural pick for champion.")},
            new SpecialCharacter() {
                Name = "Katti",
                SkipCustomization = false,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("You have big breasts with big, fuckable nipples on them, and no matter what, your vagina always seems to be there to keep you company.")},
            new SpecialCharacter() {
                Name = "Lucina",
                SkipCustomization = false,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("You're a blond, fair-skinned lass with a well-made bow and the skills to use it.  You have D-cup breasts and a very moist cunt that's seen a little action.  You're fit and trim, but not too thin, nor too well-muscled.  All in all, you're a good fit for championing your village's cause.")},
            new SpecialCharacter() {
                Name = "Navorn",
                SkipCustomization = false,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("There's been something special about you since day one, whether it's your numerous sexual endowments or your supernatural abilities.  You're a natural pick for champion.")},
            new SpecialCharacter() {
                Name = "Rope",
                SkipCustomization = false,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("Despite outward appearances, you're actually something of a neuter, with shark-like teeth, an androgynous face, and a complete lack of genitalia.")},
            new SpecialCharacter() {
                Name = "Sora",
                SkipCustomization = false,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("As a Kitsune, you always got weird looks, but none could doubt your affinity for magic...")},
            
            new SpecialCharacter() {
                Name = "With pre-defined history:",
                SkipCustomization = false,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("")},
            new SpecialCharacter() {
                Name = "Annetta",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("You're a rather well-endowed hermaphrodite that sports a thick, dog-knotted cock, an unused pussy, and a nice, stretchy butt-hole.  You've also got horns and demonic high-heels on your feet.  It makes you wonder why you would ever get chosen to be champion!")},
            new SpecialCharacter() {
                Name = "Ceveo",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("As a wandering mage you had found your way into no small amount of trouble in the search for knowledge.")},
            new SpecialCharacter() {
                Name = "Charlie",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("You're strong, smart, fast, and tough.  It also helps that you've got four dongs well beyond what others have lurking in their trousers.  With your wings, bow, weapon, and tough armor, you're a natural for protecting the town.")},
            new SpecialCharacter() {
                Name = "Chimera",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("Your body is wrecked by your own experiments with otherworldly transformation items, and now you have no more money to buy any more from smugglers... But you would make your body as strong as your will. Or die trying.")},
            new SpecialCharacter() {
                Name = "Etis",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("Kitsune-dragon hybrid with 3 tentacle cocks, tentacle hair, tentacle (well, draconic) tongue and very strong magic affinity.")},
            new SpecialCharacter() {
                Name = "Isaac",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("Born of a disgraced priestess, Isaac was raised alone until she was taken by illness.  He worked a number of odd jobs until he was eventually chosen as champion.")},
            new SpecialCharacter() {
                Name = "Leah",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("No Notes Available.")},
            new SpecialCharacter() {
                Name = "Lukaz",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("No Notes Available.")},
            new SpecialCharacter() {
                Name = "Mara",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("You're a bunny-girl with bimbo-tier curves, jiggly and soft, a curvy, wet girl with a bit of a flirty past.")},
            new SpecialCharacter() {
                Name = "Mihari",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("The portal is not something you fear, not with your imposing armor and inscribed spellblade.  You're much faster and stronger than every champion that came before you, but will it be enough?")},
            new SpecialCharacter() {
                Name = "Mirvanna",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("You're an equine dragon-herm with a rather well-proportioned body.  Ingnam is certainly going to miss having you whoring yourself out around town.  You don't think they'll miss cleaning up all the messy sex, though.")},
            new SpecialCharacter() {
                Name = "Nami",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("Your exotic appearance caused you some trouble growing up, but you buried your nose in books until it came time to go through the portal.")},
            new SpecialCharacter() {
                Name = "Nixi",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("As a German-Shepherd morph, the rest of the village never really knew what to do with you... until they sent you through the portal to face whatever's on the other side...")},
            new SpecialCharacter() {
                Name = "Prismere",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("You're more of a scout than a fighter, but you still feel confident you can handle your responsibilities as champion.  After all, what's to worry about when you can outrun everything you encounter?  You have olive skin, deep red hair, and a demonic tail and wings to blend in with the locals.")},
            new SpecialCharacter() {
                Name = "Rann Rayla",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("You're a young, fiery redhead who\'s utterly feminine.  You've got C-cup breasts and long red hair.  Being a champion can\'t be that bad, right?")},
            new SpecialCharacter() {
                Name = "Sera",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("You're something of a shemale - three rows of C-cup breasts matched with three, plump, juicy cocks.  Some decent sized balls, bat wings, and cat-like ears round out the package.")},
            new SpecialCharacter() {
                Name = "Siveen",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("You are a literal angel from beyond, and you take the place of a vilage's champion for your own reasons...")},
            new SpecialCharacter() {
                Name = "Tyriana",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("Your many, posh tits, incredible fertility, and well-used cunt made you more popular than the village bicycle.  With your cat-like ears, paws, and tail, you certainly had a feline appeal.  It's time to see how you fare in the next chapter of your life.")},
            new SpecialCharacter() {
                Name = "Vahdunbrii",
                SkipCustomization = true,
                Description = Game.SceneDocumentCreator.NewSceneDocument().AddParagraph("You're something of a powerhouse, and you wager that between your odd mutations, power strong enough to threaten the village order, and talents, you're the natural choice to send through the portal.")},
        };

        internal Dictionary<string, SpecialCharacter> GetSpecialCharactersDictionary() =>
            GetSpecialCharactersList().ToDictionary(sc => sc.Name);

        public SpecialCharacters(Game game)
        {
            Game = game;
        }
    }
}
