namespace CoC_Lib.Characters.BodyParts
{
    public class Arms : IBodyPart
    {
        public enum ArmType
        {
            Human      = 0,
            Harpy      = 1,
            Spider     = 2,
            Bee        = 3,
            Predator   = 4,
            Salamander = 5,
            Wolf       = 6,
            Cockatrice = 7,
            RedPanda   = 8,
            Ferret     = 9,
            Cat        = 10,
            Dog        = 11,
            Fox        = 12,
        }

        public ArmType Type;

        public Arms()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Type = ArmType.Human;
        }
    }
}