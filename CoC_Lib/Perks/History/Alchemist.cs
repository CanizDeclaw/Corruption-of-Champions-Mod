using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Alchemist : HistoryPerk
    {
        public static string Key => "History: Alchemist";
        public override string GetKey => Key;
        public override string Name => "History: Alchemist";
        public override string ShortName => "Alchemist";
        public override string ShortDescription =>
            "Alchemical experience makes items more reactive to your body.";
        public override string LongDescription => 
            "You spent some time as an alchemist's assistant, and alchemical " +
            "items always seem to be more reactive in your hands.";

        public override void OnAddPerk(Creature creature)
        { }
        public override void OnRemovePerk(Creature creature)
        { }

        public Alchemist()
        {
        }
    }
}