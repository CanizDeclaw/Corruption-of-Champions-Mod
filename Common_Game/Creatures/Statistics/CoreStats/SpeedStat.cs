namespace Common_Game.Creatures.Statistics
{
    public class SpeedStat : BoundedIntegerStat
    {
        public override string Name => "Speed";
        public override string Description => "Speed";

        public SpeedStat(Game game, Creature creature)
            : base(game, creature)
        {
            LowerBound = new IntLowerBound(maximum: 0);
            // TODO: This (and probably others) has a min. UpperBound of 50.
            // TODO: Ascension modifies this, str, tou, and int.
            UpperBound = new IntUpperBound(this, value: 100, minimum: 100, maximum: 200);
            Value.Set(15);
        }
    }
}