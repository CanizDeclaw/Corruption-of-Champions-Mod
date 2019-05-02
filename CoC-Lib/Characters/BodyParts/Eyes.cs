namespace CoC_Lib.Characters.BodyParts
{
    public class Eyes : IBodyPart
    {
        public enum EyeType
        {
            Human                =   0,
            FourSpiderEyes       =   1, //DEPRECATED, USE Eyes.SPIDER AND EYECOUNT = 4
            BlackEyesSandTrap    =   2,
            Lizard               =   3,
            Dragon               =   4, // Slightly different description/TF and *maybe* in the future(!) grant different perks/combat abilities
            Basilisk             =   5,
            Wolf                 =   6,
            Spider               =   7,
            Cockatrice           =   8,
            Cat                  =   9,
        }

        public EyeType Type;
        public int Count;

        public Eyes()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Type = EyeType.Human;
            Count = 2;
        }
    }
}