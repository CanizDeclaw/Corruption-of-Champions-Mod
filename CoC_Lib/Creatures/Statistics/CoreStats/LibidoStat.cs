namespace CoC_Lib.Creatures.Statistics
{
    public class LibidoStat : BoundedIntegerStat
    {
        public override string Name => "Libido";
        public override string Description => "";

        public LibidoStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(15);
            SetBaseMaximum(100);
        }
    }
}