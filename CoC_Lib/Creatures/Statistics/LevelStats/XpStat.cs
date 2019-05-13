namespace CoC_Lib.Creatures.Statistics
{
    public class XpStat : BoundedIntegerStat
    {
        public override string Name => "XP";
        public override string Description => "";

        public bool CanLevelUp => Value >= Maximum;

        public XpStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(0);
            SetBaseMaximum(100);
        }
    }
}