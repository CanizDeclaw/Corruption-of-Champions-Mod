using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Fortune : HistoryPerk
    {
        public static string Key => "History Fortune";
        public override string GetKey => Key;
        public override string Name => "Fortune";
        public override string Description =>
            "You always feel lucky when it comes to fortune.  Because of that, " +
            "you have always managed to save up gems until whatever's needed " +
            "and how to make the most out it (+15% gems on victory).  You will " +
            "also start out with 250 gems.";

        public override void OnAddPerk(Creature creature)
        {
            creature.Gems.AdjustBaseValue(250);
        }
        public override void OnRemovePerk(Creature creature)
        { }

        public Fortune()
        {
        }
    }
}