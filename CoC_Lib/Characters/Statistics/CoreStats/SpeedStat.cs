namespace CoC_Lib.Characters.Statistics
{
    public class SpeedStat : BoundedScalarIntegerStat
    {
        public override string Name => "Speed";
        public override string Description => "";
        public override int Minimum => 0;
        public override int Maximum => 100;
        public override int Value => 10;
    }
}