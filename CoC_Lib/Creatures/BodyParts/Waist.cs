using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.BodyParts
{
    // TODO: Waist should probably be a stat like Height, Thickness, and Tone
    /// <summary>
    /// Represents, essentially, waist-width for a bit more variety in character description.
    /// Description will initially be just one of [narrow, average, wide].
    /// Might be expanded by species-specific classes to include things like unusually narrow, insectoid waists.
    /// </summary>
    public abstract class Waist : AbstractBodyPart
    {
    }
}
