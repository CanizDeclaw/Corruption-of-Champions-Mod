namespace CoC_Lib.Characters.Statistics
{
    public class WillpowerStat : BoundedScalarIntegerStat
    {
        public override string Name => "Willpower";
        public override string Description => "";
        public override int Minimum => 0;
        public override int Maximum => 100;
        public override int Value { get; set; } = 80;

        public WillpowerStat(Creature creature)
            : base(creature)
        { }
    }
}