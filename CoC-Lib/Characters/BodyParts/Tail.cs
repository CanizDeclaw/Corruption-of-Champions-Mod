using System;

namespace CoC_Lib.Characters.BodyParts
{
    public class Tail : IBodyPart
    {
        public enum TailType
        {
            None          =   0,
            Horse         =   1,
            Dog           =   2,
            Demonic       =   3,
            Cow           =   4,
            SpiderAbdomen =   5,
            BeeAbdomen    =   6,
            Shark         =   7,
            Cat           =   8,
            Lizard        =   9,
            Rabbit        =  10,
            Harpy         =  11,
            Kangaroo      =  12,
            Fox           =  13,
            Draconic      =  14,
            Raccoon       =  15,
            Mouse         =  16,
            Ferret        =  17,
            Behemoth      =  18,
            Pig           =  19,
            Scorpion      =  20,
            Goat          =  21,
            Rhino         =  22,
            Echidna       =  23,
            Deer          =  24,
            Salamander    =  25,
            Wolf          =  26,
            Sheep         =  27,
            Imp           =  28,
            Cockatrice    =  29,
            RedPanda      =  30,
        }

        public TailType Type;
        /** Tail venom is a 0-100 slider used for tail attacks. Recharges per hour. */
        public double Venom;
        /** Tail recharge determines how fast venom comes back per hour. */
        public double VenomRecharge;
        /** Tail Webs is a 0-100 slider used for tail attacks. Recharges per hour. */
        public double Webs;
        /** Tail recharge determines how fast webs comes back per hour. */
        public double WebRecharge;

        public bool IsLong
        {
            get
            {
                switch (Type)
                {
                    case TailType.Dog:
                    case TailType.Demonic:
                    case TailType.Cow:
                    case TailType.Shark:
                    case TailType.Cat:
                    case TailType.Lizard:
                    case TailType.Kangaroo:
                    case TailType.Fox:
                    case TailType.Draconic:
                    case TailType.Raccoon:
                    case TailType.Mouse:
                    case TailType.Ferret:
                    case TailType.Behemoth:
                    case TailType.Scorpion:
                    case TailType.Salamander:
                    case TailType.Wolf:
                    case TailType.Imp:
                    case TailType.Cockatrice:
                    case TailType.RedPanda:
                        return true;
                    case TailType.None:
                    case TailType.Horse:
                    case TailType.SpiderAbdomen:
                    case TailType.BeeAbdomen:
                    case TailType.Rabbit:
                    case TailType.Harpy:
                    case TailType.Pig:
                    case TailType.Goat:
                    case TailType.Rhino:
                    case TailType.Echidna:
                    case TailType.Deer:
                    case TailType.Sheep:
                        return false;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Tail()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Type = TailType.None;
            Venom = 0;
            VenomRecharge = 5;
            Webs = 0;
            WebRecharge = 5;
        }
    }
}