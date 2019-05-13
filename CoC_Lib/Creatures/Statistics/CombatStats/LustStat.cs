namespace CoC_Lib.Creatures.Statistics
{
    public class LustStat : BoundedIntegerStat
    {
        public override string Name => "Lust";
        public override string Description => "";

        public LustStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(15);
            SetBaseMaximum(100);
        }
    }
}