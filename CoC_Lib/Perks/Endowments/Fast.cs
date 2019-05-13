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
        { }
        public override void OnRemovePerk(Creature creature)
        { }

        public override bool Qualified(Player player) => true;
    }
}