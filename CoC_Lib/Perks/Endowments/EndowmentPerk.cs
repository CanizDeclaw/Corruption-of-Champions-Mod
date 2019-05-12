using CoC_Lib.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Perks.Endowments
{
    public abstract class EndowmentPerk : Perk
    {
        public override string Category => "Endowment";
        public abstract bool Qualified(Player player);
    }
}
