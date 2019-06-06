using CoC_Common.Creatures;

namespace CoC_Common.Perks.History
{
    internal class Fighter : HistoryPerk
    {
        public static string Key => "History: Fighter";
        public override string GetKey => Key;
        public override string Name => "History: Fighter";
        public override string ShortName => "Fighter";
        public override string ShortDescription =>
            "A Past full of conflict increases physical damage dealt by 10%.";
        public override string LongDescription =>
            "You spent much of your time fighting other children, and you had " +
            "plans to find work as a guard when you grew up.  You do 10% more " +
            "damage with physical attacks.  You will also start out with 50 gems.";

        public override void OnAddPerk(Creature creature, bool firstTime = true)
        {
            if (firstTime)
            {
                OnFirstTimeAdd(creature);
            }
            creature.Gems.AdjustBaseValue(50);
        }

        public override void OnFirstTimeAdd(Creature creature)
        {
            throw new System.NotImplementedException();
        }

        public override void OnRemovePerk(Creature creature)
        { }

        public Fighter()
        {
        }
    }
}