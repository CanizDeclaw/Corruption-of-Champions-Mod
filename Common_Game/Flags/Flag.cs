using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Flags
{
    public abstract class Flag
    {
        public abstract string UnlockText { get; }
        public abstract string Description { get; }
        public abstract string ConditionDescription { get; }
    }
}
