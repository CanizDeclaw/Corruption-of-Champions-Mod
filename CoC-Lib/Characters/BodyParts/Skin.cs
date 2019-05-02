using System;

namespace CoC_Lib.Characters.BodyParts
{
    public class Skin : IBodyPart
    {
        public enum SkinType
        {
            Plain        =   0,
            Fur          =   1,
            LizardScales =   2,
            Goo          =   3,
            Undefined    =   4, // DEPRECATED, silently discarded upon loading a saved game
            DragonScales =   5,
            FishScales   =   6, // NYI, for future use
            Wool         =   7,
            Feathered    =   8,
            Bark         =   9,
        }

        public SkinType Type;
        public string Tone; // TODO: Better way to deal with colors
        public string Description; // TODO: Better way to deal with description
        public string Adjective; // TODO: Better way to deal with adjective
        public string FurColor; // TODO: Better way to deal with colors

        public bool HasFur => Type == SkinType.Fur;
        public bool HasWool => Type == SkinType.Wool;
        public bool HasFeathers => Type == SkinType.Feathered;

        public bool IsFurry
        {
            get
            {
                switch (Type)
                {
                    case SkinType.Fur:
                    case SkinType.Wool:
                        return true;
                    case SkinType.Plain:
                    case SkinType.LizardScales:
                    case SkinType.Goo:
                    case SkinType.Undefined:
                    case SkinType.DragonScales:
                    case SkinType.FishScales:
                    case SkinType.Feathered:
                    case SkinType.Bark:
                        return false;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public bool IsFluffy
        {
            get
            {
                switch (Type)
                {
                    case SkinType.Fur:
                    case SkinType.Wool:
                    case SkinType.Feathered:
                        return true;
                    case SkinType.Plain:
                    case SkinType.LizardScales:
                    case SkinType.Goo:
                    case SkinType.Undefined:
                    case SkinType.DragonScales:
                    case SkinType.FishScales:
                    case SkinType.Bark:
                        return false;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public Skin()
        {
            SetToDefault();
        }

        public void SetToDefault(bool keepTone = false)
        {
            Type = SkinType.Plain;
            if (!keepTone) { Tone = "albino"; }
            Description = "skin";
            Adjective = "";
            FurColor = "no";
        }
    }
}