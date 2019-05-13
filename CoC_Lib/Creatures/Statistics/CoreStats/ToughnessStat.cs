namespace CoC_Lib.Creatures.Statistics
{
    public class ToughnessStat : BoundedIntegerStat
    {
        public override string Name => "Toughness";
        public override string Description => "";

        public ToughnessStat(Creature creature)
            : base(creature)
        {
            SetBaseValue(15);
            SetBaseMaximum(100);
        }
    }
}