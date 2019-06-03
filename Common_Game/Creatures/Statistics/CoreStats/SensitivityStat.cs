namespace Common_Game.Creatures.Statistics
{
    public class SensitivityStat : BoundedIntegerStat
    {
        public override string Name => "Sensitivity";
        public override string Description => "Sensitivity";

        public SensitivityStat(Game game, Creature creature)
            : base(game, creature)
        {
            LowerBound = new IntLowerBound(maximum: 0);
            UpperBound = new IntUpperBound(this, value: 100, minimum: 100, maximum: 100);
            Minimum.StaticSetters.Add("SensitivityStat Sensitivity Minimum", 10);
            Value.Set(15);
        }
    }
}