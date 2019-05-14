using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class BigTits : EndowmentPerk
    {
        public static string Key => "Endowment: Big Tits";
        public override string GetKey => Key;
        public override string Name => "Big Tits";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Makes your tits grow larger more easily.";
        public override string LongDescription =>
            "Your breasts are bigger than average (+1 Cup Size).<br/><br/>" +
            "Larger breasts will allow you to lactate greater amounts, tit-fuck " +
            "larger cocks, and generally be a sexy bitch.";

        public override void OnAddPerk(Creature creature)
        {

        }
        public override void OnRemovePerk(Creature creature)
        {

        }

        public override bool Qualified(Player player) => player.HasBreasts;
    }
}