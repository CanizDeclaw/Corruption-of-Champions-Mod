using System;

namespace CoC_Lib.Creatures.BodyParts
{
    public abstract class Face : AbstractBodyPart
    {
        public abstract bool HasMuzzle { get; }
        public abstract bool IsHumanish { get; }
    }
}