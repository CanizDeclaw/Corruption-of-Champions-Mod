using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Healing : HistoryPerk
    {
        public static string Key => "History Healing";
        public override string GetKey => Key;
        public override string Name => "Healing";
        public override string Description =>
            "You often spent your free time with the village healer, learning " +
            "how to tend to wounds.  Healing items and effects are 20% more effective.";

        public override void OnAddPerk(Creature creature)
        {
            creature.HP.OnBaseValueAdjusting.Add(this, (adjustment) => adjustment * 0.2m);
        }
        public override void OnRemovePerk(Creature creature)
        {
            creature.HP.OnBaseValueAdjusting.Remove(this);
        }

        public Healing()
        {
        }
    }
}