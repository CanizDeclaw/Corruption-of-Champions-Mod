namespace CoC_Lib.Creatures.Statistics
{
    public class LevelStat : BoundedIntegerStat
    {
        public override string Name => "Level";
        public override string Description => "";

        public LevelStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(1);
            SetBaseMaximum(120);
        }
    }
}