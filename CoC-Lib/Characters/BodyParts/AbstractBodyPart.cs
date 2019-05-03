using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters.BodyParts
{
    public abstract class AbstractBodyPart
    {
        public Species.Type Species { get; private set; }

        // TODO: Resetting body parts will probably have to change, since
        //       they're now class-based instead of enum-based.  Mutating
        //       and resetting may become a body-level operation.
        public virtual void SetToDefault()
        {
            // Nothing to do here yet.
        }
    }
}
