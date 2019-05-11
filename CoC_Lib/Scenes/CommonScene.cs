﻿using System;
using System.Collections.Generic;
using System.Text;
using CoC_Lib.Commands;
using CoC_Lib.Commands.CommonSceneMenuCommands;

namespace CoC_Lib.Scenes
{
    /// <summary>
    /// This is the the type of scene throughout most of the game.  Camp, NPC interactions, etc.
    /// </summary>
    public class CommonScene : Scene
    {
        // Always-present commands for a CommonScene
        // Not always visible or selectable, though.
        public MainMenuCommand MainMenu { get; }
        public DataCommand Data { get; }
        public StatsCommand Stats { get; }
        public RankUpCommand RankUp { get; }
        public PerksCommand Perks { get; }
        public AppearanceCommand Appearance { get; }
        public Commands.MainMenuCommands.AchievementsCommand Achievements { get; }

        public CommonScene(Game game)
            :base(game)
        {
            MainMenu = new MainMenuCommand(game);
            Data = new DataCommand(game);
            Stats = new StatsCommand(game);
            RankUp = new RankUpCommand(game);
            Perks = new PerksCommand(game);
            Appearance = new AppearanceCommand(game);
            Achievements = new Commands.MainMenuCommands.AchievementsCommand(game);

            // TODO: This is just test data.
            Commands[0] = new Commands.MainMenuCommands.NewGameCommand(game);
            Commands[1] = new RankUpCommand(game);
            Commands[5] = new Commands.MainMenuCommands.NewGameCommand(game);
            Commands[6] = new RankUpCommand(game);

            // TODO: Remove this test text.
            SceneDescription.NewParagraph();
            SceneDescription.AddText(
                @"The offer is shocking... and yet, strangely enticing. You cannot help but
				think that it's nice to meet somebody who, even if they are more sexually
				explicit than in your village, actually approaches the matter with some decorum.
				You are still surprised and even embarrassed by the invitation, but you can't
				help but think it might be worthwhile to accept. It's for a good cause, and
				she's clearly not entirely comfortable with it herself. Maybe you've been too
				long in this world of beast-people and monsters, but she actually is kind of
				cute.");

            SceneDescription.NewParagraph();
            SceneDescription.AddText(
                @"Softly, you ask if she really does want you to mate with her, to father her
				offspring.");

            // Testing text-tag parsing
            SceneDescription.NewParagraph();
            SceneDescription.AddText(
                @"""<i>Yes. You're the best hope I have... the only hope I have.</i>"" She
				replies, sadly.");

            SceneDescription.NewParagraph();
            SceneDescription.AddText(
                @"You bow your head and tell her that if she really does need your help, you
				will help her - even if it does mean doing things with her that she doesn't
				want.");

            // AddParagraph with parseable tags.
            SceneDescription.AddParagraph(
                @"She blinks at you, clearly surprised. ""<i>I've never met a male who actually
                cared if a female wanted sex or not...</i>"" She then smiles gently. ""<i>It's
                nice to meet somebody who can still care about people as something other than
                fuck toys. Please, come with me.</i>""");

            SceneDescription.NewParagraph();
            SceneDescription.AddText(
                @"She eagerly leads you down a path, her tail swishing back and forth
				energetically. She seems very happy by your acceptance.");

            SceneDescription.NewParagraph();
            SceneDescription.AddText(
                @"It seems you've made Amily happy by asking if this is what she wants.");
        }
    }
}
