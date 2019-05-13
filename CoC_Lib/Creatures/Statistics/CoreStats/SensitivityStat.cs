namespace CoC_Lib.Creatures.Statistics
{
    public class SensitivityStat : BoundedIntegerStat
    {
        public override string Name => "Sensitivity";
        public override string Description => "";

        public SensitivityStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(15);
            SetBaseMaximum(100);
        }
    }
}