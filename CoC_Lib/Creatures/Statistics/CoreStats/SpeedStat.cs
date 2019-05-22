namespace CoC_Lib.Creatures.Statistics
{
    public class SpeedStat : BoundedIntegerStat
    {
        public override string Name => "Speed";
        public override string Description => "Speed";

        public SpeedStat(Game game, Creature creature)
            : base(game, creature)
        {
            LowerBound = new IntLowerBound(maximum: 0);
            UpperBound = new IntUpperBound(value: 100, minimum: 100, maximum: 100);
            Value.Set(15);
        }
    }
}