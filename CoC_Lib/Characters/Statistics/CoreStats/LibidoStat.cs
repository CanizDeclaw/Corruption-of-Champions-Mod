namespace CoC_Lib.Characters.Statistics
{
    public class LibidoStat : BoundedScalarIntegerStat
    {
        public override string Name => "Libido";
        public override string Description => "";
        public override int Minimum => 0;
        public override int Maximum => 100;
        public override int Value { get; set; } = 15;

        public LibidoStat(Creature creature)
            : base(creature)
        { }
    }
}