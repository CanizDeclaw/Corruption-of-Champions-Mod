namespace CoC_Lib.Creatures.Statistics
{
    public class IntelligenceStat : BoundedIntegerStat
    {
        public override string Name => "Intelligence";
        public override string Description => "";

        public IntelligenceStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(15);
            SetBaseMaximum(100);
        }
    }
}