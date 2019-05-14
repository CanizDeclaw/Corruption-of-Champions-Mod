namespace CoC_Lib.Creatures.Statistics
{
    public class StrengthStat : BoundedIntegerStat
    {
        public override string Name => "Strength";
        public override string Description => "";

        public StrengthStat(Game game, Creature creature)
            : base(game, creature)
        {
            SetBaseValue(15);
            SetBaseMaximum(100);
        }
    }
}