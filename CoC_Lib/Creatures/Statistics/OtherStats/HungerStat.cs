namespace CoC_Lib.Creatures.Statistics
{
    public class HungerStat : BoundedIntegerStat
    {
        public override string Name => "Hunger";
        public override string Description => "";

        public HungerStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(80);
            SetBaseMaximum(100);
        }
    }
}