namespace CoC_Lib.Creatures.Statistics
{
    public class SelfEsteemStat : BoundedIntegerStat
    {
        public override string Name => "Self Esteem";
        public override string Description => "";

        public SelfEsteemStat(Game game, Creature creature)
            : base(game, creature)
        {
            SetBaseValue(50);
            SetBaseMaximum(100);
        }
    }
}