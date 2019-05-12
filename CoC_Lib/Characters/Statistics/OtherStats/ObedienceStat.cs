namespace CoC_Lib.Characters.Statistics
{
    public class ObedienceStat : BoundedScalarIntegerStat
    {
        public override string Name => "Obedience";
        public override string Description => "";
        public override int Minimum => 0;
        public override int Maximum => 100;
        public override int Value { get; set; } = 10;

        public ObedienceStat(Creature creature)
            : base(creature)
        { }
    }
}