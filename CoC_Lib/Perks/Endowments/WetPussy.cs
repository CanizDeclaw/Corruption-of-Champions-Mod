﻿using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class WetPussy : EndowmentPerk
    {
        public static string Key => "Endowment: Wet Pussy";
        public override string GetKey => Key;
        public override string Name => "Wet Pussy";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Keeps your pussy wet and provides a bonus to capacity.";
        public override string LongDescription =>
            "Your pussy get particularly wet (+1 Vaginal Wetness).<br/><br/>" +
            "Vaginal wetness will make it easier to take larger cocks, in turn " +
            "helping you bring the well-endowed to orgasm quicker.";

        public override void OnAddPerk(Creature creature)
        {

        }
        public override void OnRemovePerk(Creature creature)
        {

        }

        public override bool Qualified(Player player) => player.HasVagina;
    }
}