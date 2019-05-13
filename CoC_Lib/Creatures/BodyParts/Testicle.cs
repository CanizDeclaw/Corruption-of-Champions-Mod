namespace CoC_Lib.Creatures.BodyParts
{
    public abstract class Testicle : AbstractBodyPart
    {
        public double CumMultiplier;
        public double Size;

        public Testicle()
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            CumMultiplier = 1;
            Size = 0;
        }
    }
}