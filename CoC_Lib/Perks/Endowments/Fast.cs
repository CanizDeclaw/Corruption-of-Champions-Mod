using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class Fast : EndowmentPerk
    {
        public static string Key => "Endowment: Fast";
        public override string GetKey => Key;
        public override string Name => "Fast";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Gains speed 25% faster.";
        public override string LongDescription =>
            "You are very quick (+5 Speed).<br/><br/>" +
            "Speed makes it easier to escape combat and grapples.  It also " +
            "boosts your chances of evading an enemy attack and successfully " +
            "catching up to enemies who try to run.";

        public override void OnAddPerk(Creature creature)
        {
            creature.Speed.AdjustBaseValue(5);
            creature.Tone.AdjustBaseValue(10);
            creature.Speed.OnBaseValueAdjusting.Add(this, (value) => (value > 0) ? (value * 0.25m) : 0);
        }
        public override void OnRemovePerk(Creature creature)
        {
            creature.Speed.OnBaseValueAdjusting.Remove(this);
        }

        public override bool Qualified(Player player) => true;
    }
}