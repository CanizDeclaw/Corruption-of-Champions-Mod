using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class BigCock : EndowmentPerk
    {
        public static string Key => "Endowment: Big Cock";
        public override string GetKey => Key;
        public override string Name => "Big Cock";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Gains cock size 25% faster and with less limitations.";
        public override string LongDescription =>
            "You have a big cock (+2\" Cock Length).<br/><br/>" +
            "A bigger cock will make it easier to get off any sexual partners, " +
            "but only if they can take your size.";

        public override void OnFirstTimeAdd(Creature creature)
        {
            throw new System.NotImplementedException();
        }

        public override void OnAddPerk(Creature creature, bool firstTime = true)
        {

        }

        public override void OnRemovePerk(Creature creature)
        {

        }

        public override bool Qualified(Player player) => player.Body.HasCock;
    }
}