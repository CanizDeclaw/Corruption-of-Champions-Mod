namespace CoC_Lib.Characters.Statistics
{
    public class HpStat : BoundedScalarIntegerStat
    {
        public override string Name => "HP";
        public override string Description => "";
        public override int Minimum => 0;
        public override int Maximum => 100;
        public override int Value { get; set; } = 100;

        public HpStat(Creature creature)
            : base(creature)
        { }
    }
}