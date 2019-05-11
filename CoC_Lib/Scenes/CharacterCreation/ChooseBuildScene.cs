using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    public class ChooseBuildScene : CommonScene
    {
        public ChooseBuildScene(Game game)
            : base(game)
        {
            if (game.Player.Gender.Value == "Man")
            {
                Commands[0] = new ChooseLeanCommand(game);
                Commands[1] = new ChooseAverageManCommand(game);
                Commands[2] = new ChooseThickCommand(game);
                Commands[3] = new ChooseGirlyCommand(game);
            }
            else if (game.Player.Gender.Value == "Woman")
            {
                Commands[0] = new ChooseSlenderCommand(game);
                Commands[1] = new ChooseAverageWomanCommand(game);
                Commands[2] = new ChooseCurvyCommand(game);
                Commands[3] = new ChooseTomboyishCommand(game);
            }
            else if (game.Player.Gender.Value == "Herm")
            {
                Commands[0] = new ChooseFeminineSlenderCommand(game);
                Commands[1] = new ChooseFeminineAverageCommand(game);
                Commands[2] = new ChooseFeminineCurvyCommand(game);
                Commands[3] = new ChooseFeminineTomboyishCommand(game);
                Commands[5] = new ChooseMasculineLeanCommand(game);
                Commands[6] = new ChooseMasculineAverageCommand(game);
                Commands[7] = new ChooseMasculineThickCommand(game);
                Commands[8] = new ChooseMasculineGirlyCommand(game);
            }
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
