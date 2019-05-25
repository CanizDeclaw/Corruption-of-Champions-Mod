namespace CoC_Lib.Creatures.Statistics
{
    public class CorruptionStat : BoundedIntegerStat
    {
        public override string Name => "Corruption";
        public override string Description => "Corruption";

        public CorruptionStat(Game game, Creature creature)
            : base(game, creature)
        {
            LowerBound = new IntLowerBound(maximum: 0);
            UpperBound = new IntUpperBound(this, value: 100, minimum: 100, maximum: 999);
            Value.Set(15);
        }
    }
}