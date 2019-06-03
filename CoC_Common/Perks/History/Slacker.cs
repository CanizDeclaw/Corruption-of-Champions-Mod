using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Slacker : HistoryPerk
    {
        public static string Key => "History: Slacker";
        public override string GetKey => Key;
        public override string Name => "History: Slacker";
        public override string ShortName => "Slacker";
        public override string ShortDescription =>
            "Recover from fatigue 20% faster.";
        public override string LongDescription =>
            "You spent a lot of time slacking, avoiding work, and otherwise " +
            "making a nuisance of yourself.  Your efforts at slacking have made " +
            "you quite adept at resting, and your fatigue reduces 20% faster.";

        public override void OnAddPerk(Creature creature, bool firstTime = true)
        {
            if (firstTime)
            {
                OnFirstTimeAdd(creature);
            }
            creature.Fatigue.OnBaseValueAdjusting.Add(this, (adjustment) => (adjustment < 0) ? (adjustment * 0.2m) : 0);
        }

        public override void OnFirstTimeAdd(Creature creature)
        {
            throw new System.NotImplementedException();
        }

        public override void OnRemovePerk(Creature creature)
        {
            creature.Fatigue.OnBaseValueAdjusting.Remove(this);
        }

        public Slacker()
        {
        }
    }
}