namespace CoC_Lib.Characters.BodyParts
{
    public class Butt : IBodyPart
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
        
        public void SetToDefault()
        {
            Rating = ButtRating.Buttless;
        }
    }
}