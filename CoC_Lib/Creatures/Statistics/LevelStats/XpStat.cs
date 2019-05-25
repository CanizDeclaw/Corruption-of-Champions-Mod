namespace CoC_Lib.Creatures.Statistics
{
    public class XpStat : BoundedIntegerStat
    {
        public override string Name => "XP";
        public override string Description => "";

        public bool CanLevelUp => Value >= UpperBound;

        public XpStat(Game game, Creature creature)
            : base(game, creature)
        {
            LowerBound = new IntLowerBound(value: 0, minimum: 0, maximum: 0);
            UpperBound = new IntUpperBound(this);
            Value = new BoundedIntValue(this, 0);
            Value.Set(0);
            SetBaseMaximum(100);
        }
    }
}