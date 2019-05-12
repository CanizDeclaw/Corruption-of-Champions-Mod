namespace CoC_Lib.Characters.Statistics
{
    public class ToughnessStat : BoundedScalarIntegerStat
    {
        public override string Name => "Toughness";
        public override string Description => "";
        public override int Minimum => 0;
        public override int Maximum => 100;
        public override int Value { get; set; } = 15;

        public ToughnessStat(Creature creature)
            : base(creature)
        { }
    }
}