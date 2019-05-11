using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class ChooseGameModeSettingsScene : CommonScene
    {
        public ChooseGameModeSettingsScene(Game game)
            : base(game)
        {
            Commands[0] = new ToggleSurvivalCommand(game);
            Commands[1] = new ToggleHardcoreCommand(game);
            Commands[2] = new ToggleDifficultyCommand(game);
            Commands[4] = new StartCommand(game);
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
