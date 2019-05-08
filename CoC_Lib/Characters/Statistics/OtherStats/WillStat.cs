namespace CoC_Lib.Characters.Statistics
{
    public class WillStat : BoundedScalarIntegerStat
    {
        public override string Name => "Will";
        public override string Description => "";
        public override int Minimum => 0;
        public override int Maximum => 100;
        public override int Value => 80;
    }
}