using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
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

        public override void OnAddPerk(Creature creature)
        {
            creature.Strength.AdjustBaseValue(5);
            creature.Tone.AdjustBaseValue(7);
            creature.Thickness.AdjustBaseValue(3);
            // TODO: What's with `value1` and `keySlot` in `createPerk`?
            // Assuming from description and `modStats` in `Player.as`
            // (for this and other history perks):
            creature.Strength.OnBaseValueAdjusting.Add(this, (value) => (value > 0) ? (value * 0.25m) : 0);
        }
        public override void OnRemovePerk(Creature creature)
        {
            creature.Strength.OnBaseValueAdjusting.Remove(this);
        }

        public override bool Qualified(Player player) => true;
    }
}