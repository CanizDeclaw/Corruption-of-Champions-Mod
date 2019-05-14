namespace CoC_Lib.Creatures.Statistics
{
    public class XpStat : BoundedIntegerStat
    {
        public override string Name => "XP";
        public override string Description => "";

        public bool CanLevelUp => Value >= Maximum;

        public XpStat(Game game, Creature creature)
            : base(game, creature)
        {
            SetBaseValue(0);
            SetBaseMaximum(100);
        }
    }
}