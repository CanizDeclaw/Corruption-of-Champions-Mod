namespace CoC_Lib.Creatures.Statistics
{
    public class ObedienceStat : BoundedIntegerStat
    {
        public override string Name => "Obedience";
        public override string Description => "";

        public ObedienceStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(10);
            SetBaseMaximum(100);
        }
    }
}