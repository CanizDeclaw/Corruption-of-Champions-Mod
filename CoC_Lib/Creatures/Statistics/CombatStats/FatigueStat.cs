namespace CoC_Lib.Creatures.Statistics
{
    public class FatigueStat : BoundedIntegerStat
    {
        public override string Name => "Fatigue";
        public override string Description => "";

        public FatigueStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(0);
            SetBaseMaximum(100);
        }
    }
}