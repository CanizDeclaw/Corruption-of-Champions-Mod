﻿namespace Common_Game.Bodies.BodyParts
{
    public abstract class LowerBody : AbstractBodyPart
    {
        public int LegCount;
        public abstract bool Incorporeal { get; }

        public LowerBody()
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            LegCount = 2;
        }
    }
}