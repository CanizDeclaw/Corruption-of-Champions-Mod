namespace CoC_Lib.Creatures.Statistics
{
    public class ObedienceStat : BoundedIntegerStat
    {
        public override string Name => "Obedience";
        public override string Description => "";

        public ObedienceStat(Game game, Creature creature)
            : base(game, creature)
        {
            SetBaseValue(10);
            SetBaseMaximum(100);
        }
    }
}