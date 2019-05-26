namespace CoC_Lib.Creatures.Statistics
{
    public class WillpowerStat : BoundedIntegerStat
    {
        public override string Name => "Willpower";
        public override string Description => "";

        public WillpowerStat(Game game, Creature creature)
            : base(game, creature)
        {
            LowerBound = new IntLowerBound();
            UpperBound = new IntUpperBound(this, value: 100);
            Value.Set(80);
        }
    }
}