using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class BigClit : EndowmentPerk
    {
        public static string Key => "Endowment: Big Clit";
        public override string GetKey => Key;
        public override string Name => "Big Clit";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Allows your clit to grow larger more easily and faster.";
        public override string LongDescription =>
            "You have a big clit (1\" Long).<br/><br/>" +
            "A large enough clit may eventually become as large as a cock.  It " +
            "also makes you gain lust much faster during oral or manual stimulation.";

        public override void OnAddPerk(Creature creature, bool firstTime = true)
        {
            throw new System.NotImplementedException();
        }

        public override void OnFirstTimeAdd(Creature creature)
        {
            throw new System.NotImplementedException();
        }

        public override void OnRemovePerk(Creature creature)
        {

        }

        public override bool Qualified(Player player) => player.Body.HasVagina;
    }
}