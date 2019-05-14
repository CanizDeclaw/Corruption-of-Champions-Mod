namespace CoC_Lib.Creatures.Statistics
{
    public class IntelligenceStat : BoundedIntegerStat
    {
        public override string Name => "Intelligence";
        public override string Description => "";

        public IntelligenceStat(Game game, Creature creature)
            : base(game, creature)
        {
            SetBaseValue(15);
            SetBaseMaximum(100);
        }
    }
}