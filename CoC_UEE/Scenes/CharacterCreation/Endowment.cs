using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class Endowment : CommonScene
    {
        public Endowment(Game game)
            : base(game)
        {
            var endowments = CoC_Lib.Perks.Endowments.EndowmentsList.GetList()
                .Where(e => e.Qualified(Game.Player)).ToList();
            for (int i = 0; i < endowments.Count(); i++)
            {
                Commands[i] = new EndowmentCommand(Game, endowments[i]);
            }
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
