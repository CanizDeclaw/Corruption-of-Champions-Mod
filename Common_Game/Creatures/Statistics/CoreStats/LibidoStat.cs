namespace Common_Game.Creatures.Statistics
{
    public class LibidoStat : BoundedIntegerStat
    {
        public override string Name => "Libido";
        public override string Description => "Libido";

        public LibidoStat(Game game, Creature creature)
            : base(game, creature)
        {
            LowerBound = new IntLowerBound(maximum: 0);
            UpperBound = new IntUpperBound(this, value: 100, minimum: 100, maximum: 100);
            Minimum.StaticSetters.Add("LibidoStat Libido Minimum", 1);
            Minimum.DynamicSetters.Add("LibidoStat Player Libido Minimum", () =>
            {
                if (creature is Player)
                {
                    if (creature.Body.Sex == Sex.Sexless)
                    {
                        return 10;
                    }
                    else
                    {
                        return 15;
                    }
                }
                return 0;
            });
            Minimum.DynamicSetters.Add("LibidoStat Player Libido-Lust Relation", () =>
            {
                if (creature is Player)
                {
                    return creature.Lust.Minimum * 2 / 3;
                }
                return 0;
            });
            Value.Set(15);
        }
    }
}