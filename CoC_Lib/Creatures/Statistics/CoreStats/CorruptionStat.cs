namespace CoC_Lib.Creatures.Statistics
{
    public class CorruptionStat : BoundedIntegerStat
    {
        public override string Name => "Corruption";
        public override string Description => "";

        public CorruptionStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(15);
            SetBaseMaximum(100);
        }
    }
}