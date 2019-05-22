namespace CoC_Lib.Creatures.Statistics
{
    public class LustStat : BoundedIntegerStat
    {
        public override string Name => "Lust";
        public override string Description => "Lust";

        protected string DemonicModifierKey = "LustStat DemonicModifier";
        protected decimal DemonicModifier()
        {
            if (creature is Player player &&
                player.Body.SpeciesScore(Species.Type.Demon) >= 4)
            {
                return 20;
            }
            return 0;
        }

        public LustStat(Game game, Creature creature)
            : base(game, creature)
        {
            // TODO: minLust mods
            LowerBound = new IntLowerBound(maximum: 0);
            UpperBound = new IntUpperBound(value: 100, minimum: 100, maximum: 999);
            UpperBound.DynamicModifiers.Add(DemonicModifierKey, (_) => DemonicModifier());
            // TODO: Fix this
            if (creature is Player)
            {
                Minimum.DynamicUpperBounds.Add("LustStat Player Maximal Minimum", () => 95);
            }
            Minimum.DynamicUpperBounds.Add("LustStat Player Maximal Minimum", () =>
            {
                if (creature is Player)
                {
                    return 95;
                }
                else
                {
                    return 999;
                }
            });
            Value.Set(15);
        }
    }
}