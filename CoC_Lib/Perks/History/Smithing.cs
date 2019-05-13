using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Smithing : HistoryPerk
    {
        public static string Key => "History Smithing";
        public override string GetKey => Key;
        public override string Name => "Smithing";
        public override string Description =>
            "You managed to get an apprenticeship with the local blacksmith.  " +
            "Because of your time spent at the blacksmith's side, you've learned " +
            "how to fit armor for maximum protection.";

        public override void OnAddPerk(Creature creature)
        {
            // TODO: Armor adjustment
        }
        public override void OnRemovePerk(Creature creature)
        {
            // TODO: Armor adjustment
        }

        public Smithing()
        {
        }
    }
}