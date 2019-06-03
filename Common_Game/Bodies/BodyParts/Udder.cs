namespace Common_Game.Bodies.BodyParts
{
    public abstract class Udder : AbstractBodyPart
    {
        // TODO: Improve Udder(s) conceptualization.  Types, number, teats, etc.
        public abstract bool HasUdder { get; }
        /** Udder fullness is a 0-100 slider used for how full the udder is. Recharges per hour. */
        public double Fullness;
        /** Udder refill determines how fast milk comes back per hour. */
        public double RefillRate;

        public Udder()
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            Fullness = 0;
            RefillRate = 5;
        }
    }
}