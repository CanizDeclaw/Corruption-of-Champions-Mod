namespace Common_Game.Creatures.Statistics
{
    public class LevelStat : BoundedIntegerStat
    {
        public override string Name => "Level";
        public override string Description => "Level";

        public LevelStat(Game game, Creature creature)
            : base(game, creature)
        {
            var levelMax = game.Settings.LevelMax;
            LowerBound = new IntLowerBound(value: 1, minimum: 1, maximum: levelMax);
            UpperBound = new IntUpperBound(this, value: levelMax, maximum: levelMax);
            Value.Set(1);
        }
    }
}