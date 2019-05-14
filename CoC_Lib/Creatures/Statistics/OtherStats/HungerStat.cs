namespace CoC_Lib.Creatures.Statistics
{
    public class HungerStat : BoundedIntegerStat
    {
        public override string Name => "Hunger";
        public override string Description => "";

        public HungerStat(Game game, Creature creature)
            : base(game, creature)
        {
            SetBaseValue(80);
            SetBaseMaximum(100);
        }
    }
}