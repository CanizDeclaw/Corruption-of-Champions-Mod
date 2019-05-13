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
        }
        public override void OnRemovePerk(Creature creature)
        { }

        public override bool Qualified(Player player) => true;
    }
}