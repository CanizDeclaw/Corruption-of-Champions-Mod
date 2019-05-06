namespace CoC_Lib.Characters.Statistics
{
    public class LevelStat : BoundedScalarIntegerStat
    {
        public override string Name => "Level";
        public override string Description => "";
        public override int Minimum => 0;
        public override int Maximum => 120;
        public override int Value => 0;
    }
}