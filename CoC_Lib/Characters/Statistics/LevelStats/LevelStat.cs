namespace CoC_Lib.Characters.Statistics
{
    public class LevelStat : BoundedScalarIntegerStat
    {
        public override string Name => "Level";
        public override string Description => "";
        public override int Minimum => 1;
        public override int Maximum => 120;
        public override int Value { get; set; } = 1;

        public LevelStat(Creature creature)
            : base(creature)
        { }
    }
}