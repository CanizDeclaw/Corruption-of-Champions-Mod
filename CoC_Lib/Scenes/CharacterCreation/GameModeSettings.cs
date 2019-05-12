using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class GameModeSettings : CommonScene
    {
        public GameModeSettings(Game game)
            : base(game)
        {
            Commands[0] = new ToggleSurvival(game);
            Commands[1] = new ToggleHardcore(game);
            Commands[2] = new ToggleDifficulty(game);
            Commands[4] = new StartGame(game);
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
