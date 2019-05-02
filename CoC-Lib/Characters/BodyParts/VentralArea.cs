namespace CoC_Lib.Characters.BodyParts
{
    public class VentralArea : IBodyPart
    {
        public enum VentralAreaType
        {
            None       = 0,
            Reptile    = 1,
            Dragon     = 2, // Deprecated. Changed to 1 (UnderBody.REPTILE) upon loading a savegame
            Furry      = 3,
            Naga       = 4,
            Wool       = 5, // Deprecated. Changed to 3 (UnderBody.FURRY) upon loading a savegame
            Cockatrice = 6,
        }

        public VentralAreaType Type;
        public Skin Skin = new Skin(); // TODO: Rationalize this with all the other body parts that could have 'Skin' or epidermis.

        public VentralArea()
        {
            SetToDefault();
        }

        // TODO: Source allows passing in `keepTone` variable for the skin resetter.
        public void SetToDefault()
        {
            Type = VentralAreaType.None;
            Skin.SetToDefault(true);
        }
    }
}