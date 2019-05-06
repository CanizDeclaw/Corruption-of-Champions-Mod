namespace CoC_Lib.Characters.Statistics
{
    public class LustStat : RestrictableBoundedScalarIntegerStat
    {
        public override string Name => "Lust";
        public override string Description => "";
        public override int Minimum => 0;
        public override int Maximum => 100;
        public override int Value => 0;

        public override int RestrictedMinimum => 0;
        public override int RestrictedMaximum => 100;
    }
}