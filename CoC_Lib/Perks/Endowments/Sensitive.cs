using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class Sensitive : EndowmentPerk
    {
        public static string Key => "Endowment: Sensitive";
        public override string GetKey => Key;
        public override string Name => "Sensitive";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Gains sensitivity 25% faster.";
        public override string LongDescription =>
            "Your skin unusually sensitive (+5 Sensitivity).<br/><br/>" +
            "Sensitivity affects how easily touches and certain magics will " +
            "raise your lust.  Very low sensitivity will make it difficult to orgasm.";

        public override void OnAddPerk(Creature creature)
        { }
        public override void OnRemovePerk(Creature creature)
        { }

        public override bool Qualified(Player player) => true;
    }
}