namespace Common_Game.Creatures.Statistics
{
    public class LustStat : BoundedIntegerStat
    {
        public override string Name => "Lust";
        public override string Description => "How horny you are right now.  Being full equals a loss in combat.";

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
            UpperBound = new IntUpperBound(this, value: 100, minimum: 100, maximum: 999);
            UpperBound.DynamicModifiers.Add(DemonicModifierKey, (_) => DemonicModifier());
            // TODO: Complex cap on Minimum interplay in Player.as minLust().
            if (creature is Player)
            {
                // TODO: This probably isn't player specific.
                Minimum.UpperLimitStaticSetters.Add("LustStat Player Maximal Minimum", 95);
            }
        }
    }
}