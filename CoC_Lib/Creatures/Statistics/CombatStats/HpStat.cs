namespace CoC_Lib.Creatures.Statistics
{
    public class HpStat : BoundedIntegerStat
    {
        public override string Name => "HP";
        public override string Description => "";

        public HpStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(100);
            SetBaseMaximum(100);
        }
    }
}