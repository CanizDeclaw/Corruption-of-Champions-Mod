﻿using CoC_Common.Creatures;

namespace CoC_Common.Perks.History
{
    internal class Smith : HistoryPerk
    {
        public static string Key => "History: Smith";
        public override string GetKey => Key;
        public override string Name => "History: Smith";
        public override string ShortName => "Smith";
        public override string ShortDescription =>
            "Knowledge of armor and fitting increases armor effectiveness by roughly 10%.";
        public override string LongDescription =>
            "You managed to get an apprenticeship with the local blacksmith.  " +
            "Because of your time spent at the blacksmith's side, you've learned " +
            "how to fit armor for maximum protection.";

        public override void OnAddPerk(Creature creature, bool firstTime = true)
        {
            if (firstTime)
            {
                OnFirstTimeAdd(creature);
            }
            // TODO: Armor adjustment
        }

        public override void OnFirstTimeAdd(Creature creature)
        {
            throw new System.NotImplementedException();
        }

        public override void OnRemovePerk(Creature creature)
        {
            // TODO: Armor adjustment
        }

        public Smith()
        {
        }
    }
}