namespace CoC_Lib.Creatures.Statistics
{
    public class SpeedStat : BoundedIntegerStat
    {
        public override string Name => "Speed";
        public override string Description => "";

        public SpeedStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(15);
            SetBaseMaximum(100);
        }
    }
}