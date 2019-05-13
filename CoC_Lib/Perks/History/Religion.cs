using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Religion : HistoryPerk
    {
        public static string Key => "History Religion";
        public override string GetKey => Key;
        public override string Name => "Religion";
        public override string Description =>
            "You spent a lot of time at the village temple, and learned how to " +
            "meditate.  The 'masturbation' option is replaced with 'meditate' " +
            "when corruption is at or below 66.";

        public override void OnAddPerk(Creature creature)
        {
            creature.Libido.RestrictedMinimumModifiers.Add(this, -2);
        }
        public override void OnRemovePerk(Creature creature)
        {
            creature.Libido.RestrictedMinimumModifiers.Remove(this);
        }

        public Religion()
        {
        }
    }
}