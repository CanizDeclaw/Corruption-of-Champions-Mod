using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Fighting : HistoryPerk
    {
        public static string Key => "History Fighting";
        public override string GetKey => Key;
        public override string Name => "Fighting";
        public override string Description =>
            "You spent much of your time fighting other children, and you had " +
            "plans to find work as a guard when you grew up.  You do 10% more " +
            "damage with physical attacks.  You will also start out with 50 gems.";

        public override void OnAddPerk(Creature creature)
        {
            creature.Gems.AdjustBaseValue(50);
        }
        public override void OnRemovePerk(Creature creature)
        { }

        public Fighting()
        {
        }
    }
}