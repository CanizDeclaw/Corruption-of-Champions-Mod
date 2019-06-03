namespace Common_Game.Creatures.Statistics
{
    public class HungerStat : BoundedIntegerStat
    {
        public override string Name => "Hunger";
        public override string Description => "Hunger";

        public HungerStat(Game game, Creature creature)
            : base(game, creature)
        {
            LowerBound = new IntLowerBound();
            UpperBound = new IntUpperBound(this, value: 100);
            Value.Set(80);
        }
    }
}