namespace CoC_Lib.Creatures.Statistics
{
    public abstract class ScalarStatistic : Statistic
    {
        public bool HasIncreased { get; }
        public bool HasDecreased { get; }

        public ScalarStatistic(Creature creature)
            : base(creature)
        { }
    }
}