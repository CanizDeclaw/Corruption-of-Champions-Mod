namespace CoC_Lib.Characters.BodyParts
{
    public class Ears : IBodyPart
    {
        public enum EarType
        {
            Human      =   0,
            Horse      =   1,
            Dog        =   2,
            Cow        =   3,
            Elfin      =   4,
            Cat        =   5,
            Lizard     =   6,
            Bunny      =   7,
            Kangaroo   =   8,
            Fox        =   9,
            Dragon     =  10,
            Raccoon    =  11,
            Mouse      =  12,
            Ferret     =  13,
            Pig        =  14,
            Rhino      =  15,
            Echidna    =  16,
            Deer       =  17,
            Wolf       =  18,
            Sheep      =  19,
            Imp        =  20,
            Cockatrice =  21,
            RedPanda   =  22,
        }

        public EarType Type;

        public Ears()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Type = EarType.Human;
        }
    }
}