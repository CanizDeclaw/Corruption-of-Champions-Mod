using Common_Game.Perks;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Common.Perks.History
{
    public abstract class HistoryPerk : Perk
    {
        public override string Category => "History";
        public override bool KeepOnAscension => true;
    }
}
