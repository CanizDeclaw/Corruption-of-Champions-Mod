namespace CoC_Lib.Characters.BodyParts
{
    public class Gills : IBodyPart
    {
        public enum GillType
        {
            None    = 0,
            Anemone = 1,
            Fish    = 2,
        }

        public GillType Type;

        public Gills()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Type = GillType.None;
        }
    }
}