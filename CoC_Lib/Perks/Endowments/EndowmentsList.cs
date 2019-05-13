using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Perks.Endowments
{
    public class EndowmentsList
    {
        public static List<EndowmentPerk> GetList() => new List<EndowmentPerk>()
        {
            // General
            new Strong(),
            new Tough(),
            new Fast(),
            new Smart(),
            new Lusty(),
            new Sensitive(),
            new Pervert(),
            // Cock-based
            new BigCock(),
            new LotsOfJizz(),
            // Breast-based
            new BigBreasts(),
            // Vagina-based
            new BigClit(),
            new Fertile(),
            new WetPussy(),
        };
    }
}
