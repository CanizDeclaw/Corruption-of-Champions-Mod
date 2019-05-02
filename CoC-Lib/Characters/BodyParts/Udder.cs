namespace CoC_Lib.Characters.BodyParts
{
    public class Udder : IBodyPart
    {
        // TODO: Improve Udder(s) conceptualization.  Types, number, teats, etc.
        public bool HasUdder { get; set; }
        /** Udder fullness is a 0-100 slider used for how full the udder is. Recharges per hour. */
        public double Fullness;
        /** Udder refill determines how fast milk comes back per hour. */
        public double RefillRate;

        public Udder()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            HasUdder = false;
            Fullness = 0;
            RefillRate = 5;
        }
    }
}