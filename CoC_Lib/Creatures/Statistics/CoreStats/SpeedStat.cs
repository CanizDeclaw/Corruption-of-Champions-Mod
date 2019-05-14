namespace CoC_Lib.Creatures.Statistics
{
    public class SpeedStat : BoundedIntegerStat
    {
        public override string Name => "Speed";
        public override string Description => "";

        public SpeedStat(Game game, Creature creature)
            : base(game, creature)
        {
            SetBaseValue(15);
            SetBaseMaximum(100);
        }
    }
}