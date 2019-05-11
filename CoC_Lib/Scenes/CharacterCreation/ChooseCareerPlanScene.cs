using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class ChooseCareerPlanScene : CommonScene
    {
        public ChooseCareerPlanScene(Game game)
            : base(game)
        {
            Commands[0] = new ChooseAlchemyCommand(game);
            Commands[1] = new ChooseFightingCommand(game);
            Commands[2] = new ChooseFortuneCommand(game);
            Commands[3] = new ChooseHealingCommand(game);
            Commands[4] = new ChooseReligionCommand(game);
            Commands[5] = new ChooseSchoolingCommand(game);
            Commands[6] = new ChooseSlackingCommand(game);
            Commands[7] = new ChooseSluttingCommand(game);
            Commands[8] = new ChooseSmithingCommand(game);
            Commands[9] = new ChooseWhoringCommand(game);
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
