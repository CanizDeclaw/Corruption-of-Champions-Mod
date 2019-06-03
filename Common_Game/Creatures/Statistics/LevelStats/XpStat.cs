namespace Common_Game.Creatures.Statistics
{
    public class XpStat : BoundedIntegerStat
    {
        public override string Name => "XP";
        public override string Description => "Experience Points";

        public bool CanLevelUp => Value >= UpperBound;

        public XpStat(Game game, Creature creature)
            : base(game, creature)
        {
            LowerBound = new IntLowerBound(value: 0, minimum: 0, maximum: 0);
            UpperBound = new IntUpperBound(this, value: 0);
            UpperBound.DynamicModifiers.Add("XpStat LevelModifier", (_) => creature.Level * 100);
            Value = new BoundedIntValue(this, 0, true);
        }
    }
}