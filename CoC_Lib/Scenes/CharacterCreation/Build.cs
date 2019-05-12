using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    public class Build : CommonScene
    {
        public Build(Game game)
            : base(game)
        {
            if (game.Player.Gender.Value == "Man")
            {
                Commands[0] = new LeanMan(game);
                Commands[1] = new AverageMan(game);
                Commands[2] = new ThickMan(game);
                Commands[3] = new GirlyMan(game);
            }
            else if (game.Player.Gender.Value == "Woman")
            {
                Commands[0] = new SlenderWoman(game);
                Commands[1] = new AverageWoman(game);
                Commands[2] = new CurvyWoman(game);
                Commands[3] = new TomboyishWoman(game);
            }
            else if (game.Player.Gender.Value == "Herm")
            {
                Commands[0] = new FeminineSlenderHerm(game);
                Commands[1] = new FeminineAverageHerm(game);
                Commands[2] = new FeminineCurvyHerm(game);
                Commands[3] = new FeminineTomboyishHerm(game);
                Commands[5] = new MasculineLeanHerm(game);
                Commands[6] = new MasculineAverageHerm(game);
                Commands[7] = new MasculineThickHerm(game);
                Commands[8] = new MasculineGirlyHerm(game);
            }
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
