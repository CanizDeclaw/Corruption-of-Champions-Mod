using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters.Statistics
{
    //Yes, these will probably be renamed to be less wordy.
    public abstract class RestrictableBoundedScalarIntegerStat : BoundedScalarIntegerStat
    {
        // This is pretty much the same as its ancestor, except it allows the game to restrict
        // the player from reaching max or min values by an arbitrary distance.  Useful for stats
        // that can be modified to have, say, a minimum amount of lust.
        public abstract int RestrictedMinimum { get; }
        public abstract int RestrictedMaximum { get; }
    }
}
