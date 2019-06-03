namespace Common_Game.Bodies.BodyParts
{
    public abstract class Neck : AbstractBodyPart
    {
        public double Length;
        public string Color;  // TODO: better way to do color

        public Neck()
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            Length = 2;
            Color = "no";
        }
    }
}