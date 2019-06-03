using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class History : CommonScene
    {
        public History(Game game)
            : base(game)
        {
            var history = CoC_Lib.Perks.History.HistoriesList.GetList();
            for (int i = 0; i < history.Count; i++)
            {
                Commands[i] = new HistoryCommand(Game, history[i]);
            }
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
