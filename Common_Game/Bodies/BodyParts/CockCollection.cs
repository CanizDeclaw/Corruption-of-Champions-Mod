using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Bodies.BodyParts
{
    public class CockCollection : BodyPartCollection<Cock>
    {
        public Dictionary<string, Statistics.AdjustmentModifier> OnAdjustingLength;
        public Dictionary<string, Statistics.AdjustmentModifier> OnAdjustingThickness;
        public Dictionary<string, Statistics.AdjustmentModifier> OnAdjustingKnotMultiplier;
    }
}
