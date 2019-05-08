using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes
{
    /// <summary>
    ///  This class provides the methods to construct a scene, as well as generating the final output for use.
    /// </summary>
    class SceneDescription
    {
        // TODO: Everything, but more specifically:
        // TODO: Add Italic, Bold, Underline, Result
        // TODO: Make all functions actually do stuff
        public void AddHeading() { }
        public void AddParagraph() { }

        /// <summary>
        /// Images are added by reference to a desired image directory, such as
        ///     camp\cabin
        /// which may contain images the UI may choose to display.  The path is
        /// rootless as it's up to the UI to decide where exactly the images are stored
        /// or taken from.
        /// </summary>
        public void AddImage() { }
    }
}
