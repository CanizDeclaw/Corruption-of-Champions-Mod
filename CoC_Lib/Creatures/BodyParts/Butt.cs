namespace CoC_Lib.Creatures.BodyParts
{
    public abstract class Butt : AbstractBodyPart
    {
        public enum ButtRating
        {
            Buttless         =  0,
            Tight            =  2,
            Average          =  4,
            Noticeable       =  6,
            Large            =  8,
            Jiggly           = 10,
            Expansive        = 13,
            Huge             = 16,
            InconceivablyBig = 20,
        }

        public ButtRating Rating;

        public Butt()
        {
            SetToDefault();
        }
        
        public override void SetToDefault()
        {
            base.SetToDefault();
            Rating = ButtRating.Buttless;
        }
    }
}