namespace CoC_Lib.Characters.BodyParts
{
    public class Neck : IBodyPart
    {
        public enum NeckType
        {
            Normal     = 0, // Normal human neck. Length = 2 inches
            Draconic   = 1, // (Western) Dragon neck. Length = 2-30 inches
            Cockatrice = 2,
        }

        public NeckType Type;
        public double Length;
        public string Color;  // TODO: better way to do color

        public Neck()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Type = NeckType.Normal;
            Length = 2;
            Color = "no";
        }
    }
}