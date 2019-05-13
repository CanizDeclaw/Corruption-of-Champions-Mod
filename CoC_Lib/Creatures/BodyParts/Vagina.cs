namespace CoC_Lib.Creatures.BodyParts
{
    public abstract class Vagina : AbstractBodyPart
    {
        public enum VaginalWetness
        {
            Dry       = 0,
            Normal    = 1,
            Wet       = 2,
            Slick     = 3,
            Drooling  = 4,
            Slavering = 5,
        }

        public enum VaginalLooseness
        {
          //Virgin,
            Tight      = 0,
            Normal     = 1,
            Loose      = 2,
            Gaping     = 3,
            GapingWide = 4,
            ClownCar   = 5,
        }

        public const double DefaultClitLength = 0.5;

        public VaginalWetness Wetness;
        public VaginalLooseness Looseness;
        public double ClitLength;
        public bool IsVirgin;
        public int RecoveryProgress;  // TODO: Rationalize with Anus.

        // Used during sex to determine how full it currently is.  For multi-dick sex.
        // TODO: Rationalize this with Anus (and mouth?).  Maybe/probably move it somewhere else.
        public double Fullness;

        public double WetnessFactor => 1 + (int)Wetness / 10.0;
        protected double BaseCapacity => 8 * (int)Looseness * (int)Looseness;
        public double Capacity(double bonusCapacity = 0)
        {
            return (BaseCapacity + bonusCapacity) * WetnessFactor;
        }

        public Vagina()
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            Wetness = VaginalWetness.Normal;
            Looseness = VaginalLooseness.Tight;
            ClitLength = DefaultClitLength;
            IsVirgin = true; // TODO: Source is default-false.
            RecoveryProgress = 0;
            Fullness = 0;
        }
    }
}