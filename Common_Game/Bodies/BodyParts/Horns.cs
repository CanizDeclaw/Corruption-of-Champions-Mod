namespace Common_Game.Bodies.BodyParts
{
    public abstract class Horns : AbstractBodyPart
    {
        public double Length;
        public int Count;

        public Horns()
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            Length = 0;
            Count = 0;
        }
    }
}