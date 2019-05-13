using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Slacking : HistoryPerk
    {
        public static string Key => "History Slacking";
        public override string GetKey => Key;
        public override string Name => "Slacking";
        public override string Description =>
            "You spent a lot of time slacking, avoiding work, and otherwise " +
            "making a nuisance of yourself.  Your efforts at slacking have made " +
            "you quite adept at resting, and your fatigue comes back 20% faster.";

        public override void OnAddPerk(Creature creature)
        {
            creature.Fatigue.OnBaseValueAdjusting.Add(this, (adjustment) => (adjustment < 0) ? (adjustment * 0.2m) : 0);
        }
        public override void OnRemovePerk(Creature creature)
        {
            creature.Fatigue.OnBaseValueAdjusting.Remove(this);
        }

        public Slacking()
        {
        }
    }
}