namespace CoC_Lib.Creatures.Statistics
{
    public class ToughnessStat : BoundedIntegerStat
    {
        public override string Name => "Toughness";
        public override string Description => "Toughness";

        public ToughnessStat(Game game, Creature creature)
            : base(game, creature)
        {
            LowerBound = new IntLowerBound(maximum: 0);
            UpperBound = new IntUpperBound(this, value: 100, minimum: 100, maximum: 200);
            Value.Set(15);
        }
    }
}