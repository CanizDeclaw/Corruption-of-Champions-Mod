namespace CoC_Lib.Creatures.Statistics
{
    public class ObedienceStat : BoundedIntegerStat
    {
        public override string Name => "Obedience";
        public override string Description => "Obedience";

        public ObedienceStat(Game game, Creature creature)
            : base(game, creature)
        {
            LowerBound = new IntLowerBound();
            UpperBound = new IntUpperBound(this, value: 100);
            Value.Set(10);
        }
    }
}