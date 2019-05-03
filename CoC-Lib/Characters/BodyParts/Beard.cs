namespace CoC_Lib.Characters.BodyParts
{
    public abstract class Beard : AbstractBodyPart
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

        public override void SetToDefault()
        {
            base.SetToDefault();
            Style = BeardStyle.Normal;
            Length = 0;
        }
    }
}