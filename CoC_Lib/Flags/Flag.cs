using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Flags
{
    public abstract class Flag
    {
        public abstract string Key { get; }
        public abstract string UnlockText { get; }
        public abstract string Description { get; }
        public abstract string ConditionDescription { get; }
    }
}
