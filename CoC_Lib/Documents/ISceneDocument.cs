using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Documents
{
    // TODO: Tables, <p></p> tags
    /// <summary>
    /// This class provides the methods to construct a scene, as well as generating the final output for use.
    ///  
    /// This will eventually become an interface for a document construction class injectable
    /// by the UI, so that text is output in whatever format is desired (FlowDocument, HTML, etc).
    /// 
    /// Currently puts out very basic XAML `FlowDocument`s, since they're what's used by the
    /// concurrently developed GUI.
    /// </summary>

    public enum HorizontalAlignment
    {
        Left,
        Right
    }
    public interface ISceneDocument
    {
        /// <summary>
        /// Clear the document's contents.
        /// </summary>
        /// <returns></returns>
        ISceneDocument Clear();

        #region Block Elements
        /// <summary>
        /// A Header is a paragraph containing a TextRun that is set to bold and underline.
        /// </summary>
        /// <returns>The ISceneDocument the header has been added to.</returns>
        ISceneDocument AddHeader(string headerText);
        /// <summary>
        /// Starts a new paragraph.  If there's already a pragraph open, closes it first.
        /// </summary>
        /// <returns>The ISceneDocument the paragraph has been added to.</returns>
        ISceneDocument NewParagraph();
        /// <summary>
        /// Creates a paragraph from the given text.
        /// </summary>
        /// <param name="contents">The text content of the paragraph.</param>
        /// <returns>The ISceneDocument the paragraph has been added to.</returns>
        ISceneDocument AddParagraph(string contents);
        /// <summary>
        /// Images are added by reference to a desired image directory, such as
        ///     camp\cabin
        /// which may contain images the UI may choose to display.  The path is
        /// rootless as it's up to the UI to decide where exactly the images are stored
        /// or taken from.
        /// </summary>
        /// <returns>The ISceneDocument the image has been added to.</returns>
        ISceneDocument NewImage(string imageRef);
        /// <summary>
        /// Adds a scene document as a section of the current scene document.
        /// </summary>
        /// <param name="sceneDocument">The ISceneDocument to be added as a section to the current ISceneDocument.</param>
        /// <returns>The ISceneDocument the sceneDocument has been added to.</returns>
        ISceneDocument AddSection(ISceneDocument sceneDocument);
        /// <summary>
        /// Adds a section to the scene document that can be mutated later.
        /// </summary>
        /// <param name="sectionKey">The key with which to access this particular section.</param>
        /// <returns>The ISceneDocument the mutable section has been added to.</returns>
        ISceneDocument AddMutableSection(string sectionKey);
        /// <summary>
        /// Replaces the contents of a mutable section.  The replacement should be the `Description`
        /// from another `ISceneDocument`.
        /// </summary>
        /// <param name="key">The key to access the previously created mutable section.  Section will be
        ///                   created if it doesn't already exist.</param>
        /// <param name="replacement">The replacement contents. Should be the `Description` from
        ///                           another `ISceneDocument`.</param>
        /// <returns>The ISceneDocument the mutable section is a part of.</returns>
        ISceneDocument MutateSection(string key, object replacement);
        #endregion Block Elements

        #region Inline Elements
        // A note about inline elements: like in HTML, all whitespace is converted to a single space.
        // The reason for this is so that you can type strings across multiple lines for readability, instead
        // of either having one long string extending off the edge of the screen (if word wrap is off) or
        // needing to make multiple calls to add text and manage your end/beginning-of-line spaces appropriately.

        // Interpreters should also be sure to convert <i></i>, <b></b>, and <u></u> pairs into italic, bold,
        // and underline text, respectively.  Additionally, <br/> should be recognized as a LineBreak and <p></p>
        // should be recognized as paragraph delimeters.

        #region Inline Images
        /// <summary>
        /// Adds an image as part of a run of text.  The image is flowed inline
        /// with the text; the text does not wrap around it.  You probably don't want
        /// this one since image pack contents sizes are out of your control.
        /// </summary>
        /// <param name="imageRef">Generic path spec for the image.</param>
        /// <returns>The ISceneDocument the inline image has been added to.</returns>
        ISceneDocument AddInlineImage(string imageRef);
        /// <summary>
        /// Adds an image as part of a run of text.  The image is flowed inline
        /// with the text; the text does not wrap around it.
        /// </summary>
        /// <param name="imageRef">Generic path spec for the image.</param>
        /// <param name="alignment">Which side of the page or column you want the image anchored to.</param>
        /// <returns>The ISceneDocument the inline image has been added to.</returns>
        ISceneDocument AddFigureImage(string imageRef, HorizontalAlignment alignment);
        /// <summary>
        /// Adds an image as part of a run of text.  The image is flowed inline
        /// with the text; the text does not wrap around it.
        /// </summary>
        /// <param name="imageRef">Generic path spec for the image.</param>
        /// <param name="alignment">Which side of the page or column you want the image anchored to.</param>
        /// <param name="width">How wide relative to the document display width (0-1) you want the image to be.
        ///                     Not guaranteed to be paid attention to.</param>
        /// <returns>The ISceneDocument the inline image has been added to.</returns>
        ISceneDocument AddFigureImage(string imageRef, HorizontalAlignment alignment, double width);
        #endregion Inline Images

        /// <summary>
        /// Add a linebreak to the current paragraph.
        /// </summary>
        /// <returns></returns>
        ISceneDocument AddLineBreak();

        // For scenes that need to take some user input.
        ISceneDocument AddInputBox(string key);

        // Let the player select from a list.
        // Example: Pre-made characters on the character creation screen.
        ISceneDocument AddComboBox(IList<string> list, string key);

        /// <summary>
        /// Add text to the current paragraph.  Tags *must* be closed - you can't break them across multiple calls.
        /// </summary>
        /// <param name="text">The text to be added.</param>
        /// <returns></returns>
        ISceneDocument AddText(string text);
        #endregion Inline Elements

        // TODO: Better exception.
        /// <summary>
        /// Returns the resulting description as an object.
        /// 
        /// Should throw a "FormatException" if any `BeginSomething` hasn't been paired with it's `EndSomething`.
        /// And yes, I know that's not what that exception is intended for.  See above TODO.
        /// </summary>
        object Description { get; }
    }
}
