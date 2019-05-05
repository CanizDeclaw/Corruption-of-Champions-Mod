using System;

namespace CoC_Lib.Characters.BodyParts
{
    public abstract class Wings : AbstractBodyPart
    {
        public string PrimaryColor; // TODO: A better way to do colors
        public string SecondaryColor; // TODO: A better way to do color pairs

        public abstract bool CanFly { get; }

        public Wings()
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            PrimaryColor = "no";
            SecondaryColor = "no";
        }
    }
}