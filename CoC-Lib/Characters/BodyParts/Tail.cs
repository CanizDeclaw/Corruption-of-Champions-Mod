using System;

namespace CoC_Lib.Characters.BodyParts
{
    public abstract class Tail : AbstractBodyPart
    {
        /** Tail venom is a 0-100 slider used for tail attacks. Recharges per hour. */
        public double Venom;
        /** Tail recharge determines how fast venom comes back per hour. */
        public double VenomRecharge;
        /** Tail Webs is a 0-100 slider used for tail attacks. Recharges per hour. */
        public double Webs;
        /** Tail recharge determines how fast webs comes back per hour. */
        public double WebRecharge;

        public abstract bool IsLong { get; }

        public Tail()
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            Venom = 0;
            VenomRecharge = 5;
            Webs = 0;
            WebRecharge = 5;
        }
    }
}