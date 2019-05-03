namespace CoC_Lib.Characters.BodyParts
{
    public abstract class Hips : AbstractBodyPart
    {
        public enum HipRating
        {
            Boyish        =  0,
            Slender       =  2,
            Average       =  4,
            Ample         =  6,
            Curvy         = 10,
            Fertile       = 15,
            InhumanlyWide = 20,
        }

        public HipRating Rating;

        public Hips()
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            Rating = HipRating.Boyish;
        }
    }
}