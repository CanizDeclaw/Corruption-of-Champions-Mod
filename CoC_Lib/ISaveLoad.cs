using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib
{
    /// <summary>
    /// This interface represents the means for the game to know which files to load/save to.
    /// This should be implemented by the UI and passed in to the `Game` constructor.
    /// </summary>
    public interface ISaveLoad
    {
        string DefaultSaveDirectory { get; }

        string SelectOtherSaveFile();
        string SelectOtherFileToLoad();
    }
}
