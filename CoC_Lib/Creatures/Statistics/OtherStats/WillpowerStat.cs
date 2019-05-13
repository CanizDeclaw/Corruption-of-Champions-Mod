namespace CoC_Lib.Creatures.Statistics
{
    public class WillpowerStat : BoundedIntegerStat
    {
        public override string Name => "Willpower";
        public override string Description => "";

        public WillpowerStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(80);
            SetBaseMaximum(100);
        }
    }
}