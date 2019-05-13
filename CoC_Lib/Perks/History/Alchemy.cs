using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Alchemy : HistoryPerk
    {
        public static string Key => "History Alchemy";
        public override string GetKey => Key;
        public override string Name => "Alchemy";
        public override string Description => 
            "You spent some time as an alchemist's assistant, and alchemical " +
            "items always seem to be more reactive in your hands.";

        public override void OnAddPerk(Creature creature)
        { }
        public override void OnRemovePerk(Creature creature)
        { }

        public Alchemy()
        {
        }
    }
}