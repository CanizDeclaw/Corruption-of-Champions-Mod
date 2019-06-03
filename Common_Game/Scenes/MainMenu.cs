using Common_Game.Commands.MainMenuCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Scenes
{
    public class MainMenu : Scene
    {
        // These are here just to make it more explicit in this particular case.
        // The Commands[] still works.
        public ContinueCommand Continue;
        public NewGameCommand NewGame;
        public DataCommand Data;
        public OptionsCommand Options;
        public AchievementsCommand Achievements;
        public InstructionsCommand Instructions;
        public CreditsCommand Credits;
        public ModThreadCommand ModThread;

        public MainMenu(Game game)
            :base(game)
        {
            Continue = new ContinueCommand(Game);
            NewGame = new NewGameCommand(Game);
            Data = new DataCommand(Game);
            Options = new OptionsCommand(Game);
            Achievements = new AchievementsCommand(Game);
            Instructions = new InstructionsCommand(Game);
            Credits = new CreditsCommand(Game);
            ModThread = new ModThreadCommand(Game);

            Commands[0] = Continue;
            Commands[1] = NewGame;
            Commands[2] = Data;
            Commands[3] = Options;
            Commands[4] = Achievements;
            Commands[5] = Instructions;
            Commands[6] = Credits;
            Commands[7] = ModThread;
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
