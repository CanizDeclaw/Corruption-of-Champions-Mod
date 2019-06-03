namespace Common_Game.Creatures.Statistics
{
    public class FatigueStat : BoundedIntegerStat
    {
        public override string Name => "Fatigue";
        public override string Description => "How tired you are.  Lower is better.";

        public FatigueStat(Game game, Creature creature)
            : base(game, creature)
        {
            Value = 0;
            LowerBound = new IntLowerBound(maximum: 100);
            UpperBound = new IntUpperBound(this, value: 100, minimum: 100, maximum: 999);
        }
    }
}