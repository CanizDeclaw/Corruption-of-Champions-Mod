namespace CoC_Lib.Characters.BodyParts
{
    public abstract class Hair : AbstractBodyPart
    {
        public string Color; // TODO: Better method of working with color
        public double Length;

        public Hair()
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            Color = "no";
            Length = 0;
        }
    }
}