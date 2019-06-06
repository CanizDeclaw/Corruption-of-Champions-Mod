using CoC_Common.Creatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Common.Perks.Endowments
{
    public abstract class EndowmentPerk : Perk
    {
        public override string Category => "Endowment";
        public override bool KeepOnAscension => true;
        public abstract bool Qualified(Player player);
    }
}
