namespace CoC_Lib.Creatures.Statistics
{
    public class LustStat : BoundedIntegerStat
    {
        public override string Name => "Lust";
        public override string Description => "";

        public LustStat(Game game, Creature creature)
            : base(game, creature)
        {
            SetBaseValue(15);
            SetBaseMaximum(100);
        }
    }
}