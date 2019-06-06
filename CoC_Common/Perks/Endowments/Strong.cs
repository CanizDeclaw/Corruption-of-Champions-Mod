using CoC_Common.Creatures;

namespace CoC_Common.Perks.Endowments
{
    internal class Strong : EndowmentPerk
    {
        public static string Key => "Endowment: Strong";
        public override string GetKey => Key;
        public override string Name => "Strong";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Gains strength 25% faster.";
        public override string LongDescription =>
            "You are stronger than normal (+5 Strength).<br/><br/>" +
            "Strength increases your combat damage, and your ability to hold on " +
            "to an enemy or pull yourself away.";

        public override void OnAddPerk(Creature creature, bool firstTime = true)
        {
            if (firstTime)
            {
                OnFirstTimeAdd(creature);
            }
            // TODO: What's with `value1` and `keySlot` in `createPerk`?
            // Assuming from description and `modStats` in `Player.as`
            // (for this and other history perks):
            creature.Strength.Value.OnAdjusting.Add(Key, (value) => (value > 0) ? (value * 0.25m) : 0);
        }

        public override void OnFirstTimeAdd(Creature creature)
        {
            creature.Strength.Increase(5);
            creature.Body.Tone.Increase(7);
            creature.Body.Thickness.Increase(3);
        }

        public override void OnRemovePerk(Creature creature)
        {
            creature.Strength.Value.OnAdjusting.Remove(Key);
        }

        public override bool Qualified(Player player) => true;
    }
}