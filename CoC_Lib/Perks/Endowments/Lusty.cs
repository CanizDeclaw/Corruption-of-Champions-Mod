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
        { }
        public override void OnRemovePerk(Creature creature)
        { }

        public override bool Qualified(Player player) => true;
    }
}