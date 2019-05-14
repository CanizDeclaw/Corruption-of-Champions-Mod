namespace CoC_Lib.Creatures.Statistics
{
    public class LibidoStat : BoundedIntegerStat
    {
        public override string Name => "Libido";
        public override string Description => "";

        public LibidoStat(Game game, Creature creature)
            : base(game, creature)
        {
            SetBaseValue(15);
            SetBaseMaximum(100);
        }
    }
}