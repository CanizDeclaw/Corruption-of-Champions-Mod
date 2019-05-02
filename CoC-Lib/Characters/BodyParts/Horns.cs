namespace CoC_Lib.Characters.BodyParts
{
    public class Horns : IBodyPart
    {
        public enum HornType
        {
            None        =   0,
            Demon       =   1,
            CowMinotaur =   2,
            Draconic    =   3, // Was: Draconic_x2
                               //      Draconic_x4_12_inch_long = 4, 
            Antlers     =   5,
            Goat        =   6,
            Unicorn     =   7,
            Rhino       =   8,
            Sheep       =   9,
            Ram         =  10,
            Imp         =  11,
        }

        public HornType Type;
        public double Length;
        public int Count;

        public Horns()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Type = HornType.None;
            Length = 0;
            Count = 0;
        }
    }
}