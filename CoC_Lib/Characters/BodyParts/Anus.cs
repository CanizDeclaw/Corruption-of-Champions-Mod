namespace CoC_Lib.Characters.BodyParts
{
    public abstract class Anus : AbstractBodyPart
    {
        public enum AnalWetness
        {
            Dry           = 0,
            Normal        = 1,
            Moist         = 2,
            Slimy         = 3,
            Drooling      = 4,
            SlimeDrooling = 5,
        }

        public enum AnalLooseness
        {
            Virgin    = 0,
            Tight     = 1,
            Normal    = 2,
            Loose     = 3,
            Stretched = 4,
            Gaping    = 5,
        }

        public AnalWetness Wetness;
        public AnalLooseness Looseness;
        // TODO: rationalize virginity across this, vagina, and cock (and mouth?)
        public bool IsVirgin => Looseness == AnalLooseness.Virgin;

        public Anus()
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            Wetness = AnalWetness.Dry;
            Looseness = AnalLooseness.Virgin;
        }
    }
}