namespace CoC_Lib.Characters.BodyParts
{
    public class Hair : IBodyPart
    {
        public enum HairType
        {
            Normal         = 0,
            Feather        = 1,
            Ghost          = 2,
            Goo            = 3,
            Anemone        = 4,
            Quill          = 5,
            BasiliskSpines = 6,
            BasiliskPlume  = 7,
            Wool           = 8,
            Leaf           = 9,
        }

        public HairType Type;
        public string Color; // TODO: Better method of working with color
        public double Length;

        public Hair()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Type = HairType.Normal;
            Color = "no";
            Length = 0;
        }
    }
}