using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Healer : HistoryPerk
    {
        public static string Key => "History: Healer";
        public override string GetKey => Key;
        public override string Name => "History: Healer";
        public override string ShortName => "Healer";
        public override string ShortDescription =>
            "Healing experience increases HP gains by 20%.";
        public override string LongDescription =>
            "You often spent your free time with the village healer, learning " +
            "how to tend to wounds.  Healing items and effects are 20% more effective.";

        public override void OnAddPerk(Creature creature)
        {
            creature.HP.OnBaseValueAdjusting.Add(this, (adjustment) => (adjustment > 0) ? (adjustment * 0.2m) : 0);
        }
        public override void OnRemovePerk(Creature creature)
        {
            creature.HP.OnBaseValueAdjusting.Remove(this);
        }

        public Healer()
        {
        }
    }
}