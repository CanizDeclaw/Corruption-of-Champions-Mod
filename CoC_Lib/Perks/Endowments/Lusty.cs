using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class Lusty : EndowmentPerk
    {
        public static string Key => "Endowment: Lusty";
        public override string GetKey => Key;
        public override string Name => "Lusty";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Gains lust 25% faster.";
        public override string LongDescription =>
            "You have an unusually high sex-drive (+5 Libido).<br/><br/>" +
            "Libido affects how quickly your lust builds over time.  You may " +
            "find a high libido to be more trouble than it's worth...";

        public override void OnAddPerk(Creature creature)
        {
            creature.Libido.AdjustBaseValue(5);
            creature.Libido.OnBaseValueAdjusting.Add(this, (value) => (value > 0) ? (value * 0.25m) : 0);
        }
        public override void OnRemovePerk(Creature creature)
        {
            creature.Libido.OnBaseValueAdjusting.Remove(this);
        }

        public override bool Qualified(Player player) => true;
    }
}