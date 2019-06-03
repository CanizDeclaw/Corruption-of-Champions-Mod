namespace Common_Game.Creatures.Statistics
{
    public class SelfEsteemStat : BoundedIntegerStat
    {
        public override string Name => "Self Esteem";
        public override string Description => "";

        public SelfEsteemStat(Game game, Creature creature)
            : base(game, creature)
        {
            LowerBound = new IntLowerBound();
            UpperBound = new IntUpperBound(this, value: 100);
            Value.Set(50);
        }
    }
}