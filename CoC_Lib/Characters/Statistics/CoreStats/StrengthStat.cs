namespace CoC_Lib.Characters.Statistics
{
    public class StrengthStat : BoundedScalarIntegerStat
    {
        public override string Name => "Strength";
        public override string Description => "";
        public override int Minimum => 0;
        public override int Maximum => 100;
        public override int Value => 15;
    }
}