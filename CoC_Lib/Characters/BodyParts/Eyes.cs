namespace CoC_Lib.Characters.BodyParts
{
    public abstract class Eyes : AbstractBodyPart
    {
        public int Count;

        public Eyes()
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            Count = 2;
        }
    }
}