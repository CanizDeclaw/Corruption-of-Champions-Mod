using System;

namespace CoC_Lib.Characters.BodyParts
{
    public class Tongue : IBodyPart
    {
        public enum TongueType
        {
            Human    =   0,
            Snake    =   1,
            Demonic  =   2,
            Draconic =   3,
            Echidna  =   4,
            Lizard   =   5,
            Cat      =   6,
        }

        public TongueType Type;

        public bool IsLong
        {
            get
            {
                switch (Type)
                {
                    case TongueType.Demonic:
                    case TongueType.Draconic:
                    case TongueType.Echidna:
                        return true;
                    case TongueType.Human:
                    case TongueType.Snake:
                    case TongueType.Lizard:
                    case TongueType.Cat:
                        return false;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
        public Tongue()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Type = TongueType.Human;
        }
    }
}