using System;

namespace Common_Game.Bodies.BodyParts
{
    public abstract class Skin : AbstractBodyPart
    {

        public string Tone; // TODO: Better way to deal with colors
        public string Description; // TODO: Better way to deal with description
        public string Adjective; // TODO: Better way to deal with adjective
        public string FurColor; // TODO: Better way to deal with colors

        public abstract Species.SkinType Type { get; } // TODO: Probably not the way this should be handled, exactly.
        public abstract bool HasFur { get; }
        public abstract bool HasWool { get; }
        public abstract bool HasFeathers { get; }
        public abstract bool IsFurry { get; }
        public bool IsFluffy { get; }

        public Skin()
        {
            SetToDefault();
        }

        public void SetToDefault(bool keepTone = false)
        {
            base.SetToDefault();
            if (!keepTone) { Tone = "albino"; }
            Description = "skin";
            Adjective = "";
            FurColor = "no";
        }
    }
}