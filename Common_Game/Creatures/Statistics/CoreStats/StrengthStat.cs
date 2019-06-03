namespace Common_Game.Creatures.Statistics
{
    public class StrengthStat : BoundedIntegerStat
    {
        public override string Name => "Strength";
        public override string Description => "Strength";

        public StrengthStat(Game game, Creature creature)
            : base(game, creature)
        {
            // TODO: getAllMaxStats has some ascension changes for this and others.
            LowerBound = new IntLowerBound(maximum: 0);
            UpperBound = new IntUpperBound(this, value: 100, minimum: 100, maximum: 200);
            Value.Set(15);
        }
    }
}