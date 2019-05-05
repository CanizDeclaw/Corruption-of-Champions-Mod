using System;

namespace CoC_Lib.Characters.BodyParts
{
    // TODO: This class, VentralArea, and Skin probably need rethinking.  Especially since
    //       pretty much everything should be able to be colored independently.  Might be
    //       better to make Torso class and/or put general colorings at body-level.
    public abstract class DorsalArea : AbstractBodyPart
    {
        public string Color;  // TODO: Better object type and/or setter.

        public abstract bool CanDye { get; }

        public DorsalArea()
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            Color = "no";
        }
    }
}