namespace CoC_Lib.Creatures.Statistics
{
    public class FatigueStat : BoundedIntegerStat
    {
        public override string Name => "Fatigue";
        public override string Description => "";

        public FatigueStat(Game game, Creature creature)
            : base(game, creature)
        {
            Value = 0;
            LowerBound = new IntLowerBound(maximum: 100);
            UpperBound = new IntUpperBound(value: 100, minimum: 100, maximum: 999);
        }
    }
}