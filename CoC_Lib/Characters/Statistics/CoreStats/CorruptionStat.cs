namespace CoC_Lib.Characters.Statistics
{
    public class CorruptionStat : BoundedScalarIntegerStat
    {
        public override string Name => "Corruption";
        public override string Description => "";
        public override int Minimum => 0;
        public override int Maximum => 100;
        public override int Value { get; set; } = 15;

        public CorruptionStat(Creature creature)
            : base(creature)
        { }
    }
}