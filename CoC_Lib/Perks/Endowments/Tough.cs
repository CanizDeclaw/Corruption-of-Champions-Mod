﻿using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class Tough : EndowmentPerk
    {
        public static string Key => "Endowment: Tough";
        public override string GetKey => Key;
        public override string Name => "Tough";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Gains toughness 25% faster.";
        public override string LongDescription =>
            "You are unusually tough (+5 Toughness).<br/><br/>" +
            "Toughness gives you more HP and increases the chances an attack " +
            "against you will fail to wound you.";

        public override void OnAddPerk(Creature creature)
        { }
        public override void OnRemovePerk(Creature creature)
        { }

        public override bool Qualified(Player player) => true;
    }
}