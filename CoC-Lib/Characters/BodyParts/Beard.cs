namespace CoC_Lib.Characters.BodyParts
{
    public class Beard : IBodyPart
    {
        public enum BeardStyle
        {
            Normal      = 0,
            Goatee      = 1,
            CleanCut    = 2,
            MountainMan = 3,
        }

        public BeardStyle Style;
        public double Length;

        public Beard()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Style = BeardStyle.Normal;
            Length = 0;
        }
    }
}