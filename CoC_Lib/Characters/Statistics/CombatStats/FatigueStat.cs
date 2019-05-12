namespace CoC_Lib.Characters.Statistics
{
    public class FatigueStat : BoundedScalarIntegerStat
    {
        public override string Name => "Fatigue";
        public override string Description => "";
        public override int Minimum => 0;
        public override int Maximum => 100;
        public override int Value { get; set; } = 0;

        public FatigueStat(Creature creature)
            : base(creature)
        { }
    }
}