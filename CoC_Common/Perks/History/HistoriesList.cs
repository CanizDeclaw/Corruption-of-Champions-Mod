using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Common.Perks.History
{
    class HistoriesList
    {
        public static List<HistoryPerk> GetList() => new List<HistoryPerk>()
        {
            new Alchemist(),
            new Fighter(),
            new Fortune(),
            new Healer(),
            new Religious(),
            new Scholar(),
            new Slacker(),
            new Slut(),
            new Smith(),
            new Whore(),
        };
    }
}
