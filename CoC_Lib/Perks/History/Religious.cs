using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Religious : HistoryPerk
    {
        public static string Key => "History: Religious";
        public override string GetKey => Key;
        public override string Name => "History: Religious";
        public override string ShortName => "Religious";
        public override string ShortDescription =>
            "Replaces masturbate with meditate when corruption less than or " +
            "equal to 66. Reduces minimum libido slightly.";
        public override string LongDescription =>
            "You spent a lot of time at the village temple, and learned how to " +
            "meditate.  The 'masturbation' option is replaced with 'meditate' " +
            "when corruption is at or below 66.";

        public override void OnAddPerk(Creature creature, bool firstTime = true)
        {
            creature.Libido.RestrictedMinimumModifiers.Add(this, -2);
        }

        public override void OnFirstTimeAdd(Creature creature)
        {
            throw new System.NotImplementedException();
        }

        public override void OnRemovePerk(Creature creature)
        {
            creature.Libido.RestrictedMinimumModifiers.Remove(this);
        }

        public Religious()
        {
        }
    }
}