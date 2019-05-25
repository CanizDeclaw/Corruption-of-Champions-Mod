namespace CoC_Lib.Creatures.Statistics
{
    public class IntelligenceStat : BoundedIntegerStat
    {
        public override string Name => "Intelligence";
        public override string Description => "Intelligence";

        public IntelligenceStat(Game game, Creature creature)
            : base(game, creature)
        {
            // TODO: All stats need better checked for implementation.
            //       Just doing basic implementation for now, for the most part.
            LowerBound = new IntLowerBound(maximum: 0);
            UpperBound = new IntUpperBound(this, value: 100, minimum: 100, maximum: 200);
            Value.Set(15);
        }
    }
}