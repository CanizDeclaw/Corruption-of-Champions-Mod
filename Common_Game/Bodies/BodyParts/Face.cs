using System;

namespace Common_Game.Bodies.BodyParts
{
    public abstract class Face : AbstractBodyPart
    {
        public abstract bool HasMuzzle { get; }
        public abstract bool IsHumanish { get; }
    }
}