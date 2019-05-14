namespace CoC_Lib.Creatures.Statistics
{
    public class FatigueStat : BoundedIntegerStat
    {
        public override string Name => "Fatigue";
        public override string Description => "";

        public FatigueStat(Game game, Creature creature)
            : base(game, creature)
        {
            SetBaseValue(0);
            SetBaseMaximum(100);
        }
    }
}