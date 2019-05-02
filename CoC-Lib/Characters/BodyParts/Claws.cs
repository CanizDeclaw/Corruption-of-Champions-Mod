namespace CoC_Lib.Characters.BodyParts
{
    public class Claws : IBodyPart
    {
        public enum ClawType
        {
            Normal     = 0,
            Lizard     = 1,
            Dragon     = 2,
            Salamander = 3,
            Cat        = 4,
            Dog        = 5,
            Fox        = 6,
            Mantis     = 7, // NYI! Placeholder for Xianxia mod
            Imp        = 8,
            Cockatrice = 9,
            RedPanda   = 10,
            Ferret     = 11,
        }

        public ClawType Type;

        public Claws()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Type = ClawType.Normal;
        }
    }
}