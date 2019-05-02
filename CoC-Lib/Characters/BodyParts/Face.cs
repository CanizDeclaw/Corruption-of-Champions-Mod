namespace CoC_Lib.Characters.BodyParts
{
    public class Face : IBodyPart
    {
        public enum FaceType
        {
            Human        =   0,
            Horse        =   1,
            Dog          =   2,
            CowMinotaur  =   3,
            SharkTeeth   =   4,
            SnakeFangs   =   5,
            Catgirl      =   6,
            Lizard       =   7,
            Bunny        =   8,
            Kangaroo     =   9,
            SpiderFangs  =  10,
            Fox          =  11,
            Dragon       =  12,
            RaccoonMask  =  13,
            Raccoon      =  14,
            Buckteeth    =  15,
            Mouse        =  16,
            FerretMask   =  17,
            Ferret       =  18,
            Pig          =  19,
            Boar         =  20,
            Rhino        =  21,
            Echidna      =  22,
            Deer         =  23,
            Wolf         =  24,
            Cockatrice   =  25,
            Beak         =  26, // This is a placeholder for the next beaked face type, so feel free to refactor (rename)
            RedPanda     =  27,
            Cat          =  28,
        }

        public FaceType Type;

        public Face()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Type = FaceType.Human;
        }
    }
}