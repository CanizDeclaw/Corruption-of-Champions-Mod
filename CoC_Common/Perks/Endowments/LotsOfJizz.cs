﻿using CoC_Common.Creatures;

namespace CoC_Common.Perks.Endowments
{
    // Note: Renamed from "MessyOrgasms" to be more clear about what it applies to.
    internal class LotsOfJizz : EndowmentPerk
    {
        public static string Key => "Endowment: Lots of Jizz";
        public override string GetKey => Key;
        public override string Name => "Lots of Jizz";
        public override string ShortName => "LotsOfJizz";
        public override string ShortDescription =>
            "Produces 50% more cum volume.";
        public override string LongDescription =>
            "Your orgasms are particularly messy (+50% Cum Multiplier).<br/><br/>" +
            "A higher cum multiplier will cause your orgasms to be messier.";

        public override void OnAddPerk(Creature creature, bool firstTime = true)
        {
            if (firstTime)
            {
                OnFirstTimeAdd(creature);
            }

        }

        public override void OnFirstTimeAdd(Creature creature)
        {
            throw new System.NotImplementedException();
        }

        public override void OnRemovePerk(Creature creature)
        {

        }

        public override bool Qualified(Player player) => player.Body.HasCock;
    }
}