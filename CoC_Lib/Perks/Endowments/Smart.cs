﻿using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class Smart : EndowmentPerk
    {
        public static string Key => "Endowment: Smart";
        public override string GetKey => Key;
        public override string Name => "Smart";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Gains intelligence 25% faster.";
        public override string LongDescription =>
            "You are a quick learner (+5 Intellect).<br/><br/>" +
            "Intellect can help you avoid dangerous monsters or work with " +
            "machinery.  It will also boost the power of any spells you may " +
            "learn in your travels.";

        public override void OnAddPerk(Creature creature, bool firstTime = true)
        {
            if (firstTime)
            {
                OnFirstTimeAdd(creature);
            }
            creature.Intelligence.Value.OnAdjusting.Add(Key, (value) => (value > 0) ? (value * 0.25m) : 0);
        }

        public override void OnFirstTimeAdd(Creature creature)
        {
            creature.Intelligence.Increase(5);
            creature.Body.Thickness.Decrease(5);
        }

        public override void OnRemovePerk(Creature creature)
        {
            creature.Intelligence.Value.OnAdjusting.Remove(Key);
        }

        public override bool Qualified(Player player) => true;
    }
}