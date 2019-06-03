namespace Common_Game.Bodies.BodyParts
{
    public abstract class VentralArea : AbstractBodyPart
    {
        public Species.SkinType Type; // TODO: Not exactly.  This class needs a serious rethink.
        public abstract Skin Skin { get; } // TODO: Rationalize this with all the other body parts that could have 'Skin' or epidermis.

        public VentralArea()
        {
            SetToDefault();
        }

        // TODO: Source allows passing in `keepTone` variable for the skin resetter.
        public override void SetToDefault()
        {
            base.SetToDefault();
            Skin.SetToDefault(true);
        }
    }
}