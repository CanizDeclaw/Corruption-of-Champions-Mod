namespace CoC_Lib.Characters.BodyParts
{
    public class Testicle : IBodyPart
    {
        public enum TesticleType
        {
            Normal = 0,
            Bunny  = 1, // Bunny 'testicles' == eggs.
        }

        public TesticleType Type;
        public double CumMultiplier;
        public double Size;

        public Testicle()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Type = TesticleType.Normal;
            CumMultiplier = 1;
            Size = 0;
        }
    }
}