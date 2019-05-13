using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class Pervert : EndowmentPerk
    {
        public static string Key => "Endowment: Pervert";
        public override string GetKey => Key;
        public override string Name => "Pervert";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Gains corruption 25% faster. Reduces corruption requirement for " +
            "high-corruption variant of scenes.";
        public override string LongDescription =>
            "You are unusually perverted (+5 Corruption).<br/><br/>" +
            "Corruption affects certain scenes and having a higher corruption " +
            "makes you more prone to Bad Ends.";

        public override void OnAddPerk(Creature creature)
        { }
        public override void OnRemovePerk(Creature creature)
        { }

        public override bool Qualified(Player player) => true;
    }
}