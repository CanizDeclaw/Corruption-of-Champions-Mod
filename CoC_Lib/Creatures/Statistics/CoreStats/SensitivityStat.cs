namespace CoC_Lib.Creatures.Statistics
{
    public class SensitivityStat : BoundedIntegerStat
    {
        public override string Name => "Sensitivity";
        public override string Description => "";

        public SensitivityStat(Game game, Creature creature)
            : base(game, creature)
        {
            SetBaseValue(15);
            SetBaseMaximum(100);
        }
    }
}