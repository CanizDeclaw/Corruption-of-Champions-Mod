using System;

namespace CoC_Lib.Characters.BodyParts
{
    public class DorsalArea : IBodyPart
    {
        public enum DorsalAreaDecoration
        {
            None           = 0,
            DraconicMane   = 1,
            DraconicSpikes = 2,
            SharkFin       = 3,
        }

        public DorsalAreaDecoration Decoration;  // TODO: Pick a better name.
        public string Color;  // TODO: Better object type and/or setter.

        public bool CanDye
        {
            get
            {
                switch (Decoration)
                {
                    case DorsalAreaDecoration.DraconicMane:
                        return true;
                    case DorsalAreaDecoration.None:
                    case DorsalAreaDecoration.DraconicSpikes:
                    case DorsalAreaDecoration.SharkFin:
                        return false;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public DorsalArea()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Decoration = DorsalAreaDecoration.None;
            Color = "no";
        }
    }
}