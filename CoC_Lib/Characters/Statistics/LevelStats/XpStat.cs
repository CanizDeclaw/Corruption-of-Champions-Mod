namespace CoC_Lib.Characters.Statistics
{
    public class XpStat : BoundedScalarIntegerStat
    {
        public override string Name => "XP";
        public override string Description => "";
        public override int Minimum => 0;
        public override int Maximum => 100;
        public override int Value { get; set; } = 0;

        public bool CanLevelUp => Value >= Maximum;

        public XpStat(Creature creature)
            : base(creature)
        { }
    }
}