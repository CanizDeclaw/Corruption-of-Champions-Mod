using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Perks.History
{
    class HistoriesList
    {
        public static List<HistoryPerk> GetList() => new List<HistoryPerk>()
        {
            new Alchemy(),
            new Fighting(),
            new Fortune(),
            new Healing(),
            new Religion(),
            new Schooling(),
            new Slacking(),
            new Slutting(),
            new Smithing(),
            new Whoring(),
        };
    }
}
