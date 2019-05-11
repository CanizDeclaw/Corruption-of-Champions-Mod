using CoC_Lib.Documents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using HorizontalAlignment = CoC_Lib.Documents.HorizontalAlignment;

namespace CoC_Desktop_WPF.Utilities.Documents
{
    internal class SceneFlowDocument : ISceneDocument
    {
        protected ImageManager ImageManager;
        protected FlowDocument document;
        protected Dictionary<string, TextBox> textboxes;
        protected Dictionary<string, ComboBox> comboboxes;
        protected Dictionary<string, Section> mutableSections;

        private Block _currentBlock = null;
        protected Block CurrentBlock
        {
            get => _currentBlock;
            set
            {
                if (_currentBlock != null)
                {
                    document.Blocks.Add(_currentBlock);
                }
                _currentBlock = value;
            }
        }

        protected const double DefaultImageWidth = 0.5;
        protected const System.Windows.FigureUnitType DefaultFigureUnitType = System.Windows.FigureUnitType.Page;

        #region ISceneDocument Implementation
        /// <summary>
        /// Clear the document's contents.
        /// </summary>
        /// <returns></returns>
        public ISceneDocument Clear()
        {
            CurrentBlock = null;
            document.Blocks.Clear();
            textboxes.Clear();
            comboboxes.Clear();
            mutableSections.Clear();

            return this;
        }

        #region Block Elements
        /// <summary>
        /// A Header is a paragraph containing a TextRun that is set to bold and underline.
        /// </summary>
        /// <returns>The ISceneDocument the header has been added to.</returns>
        public ISceneDocument AddHeader(string headerText)
        {
            // Headers are intended to be an entire block, so we first push the header, then
            // we push null to force a new block.
            CurrentBlock = new Paragraph(new Bold(new Underline(new Run(headerText))));
            CurrentBlock = null;
            return this;
        }
        /// <summary>
        /// Starts a new paragraph.  If there's already a pragraph open, closes it first.
        /// </summary>
        /// <returns>The ISceneDocument the paragraph has been added to.</returns>
        public ISceneDocument NewParagraph()
        {
            CurrentBlock = new Paragraph();
            return this;
        }
        /// <summary>
        /// Creates a paragraph from the given text.  Use `NewParagraph()` if you need to add
        /// more than just the parameter text.
        /// </summary>
        /// <param name="contents">The text content of the paragraph.</param>
        /// <returns>The ISceneDocument the paragraph has been added to.</returns>
        public ISceneDocument AddParagraph(string contents)
        {
            var paragraph = new Paragraph();
            var inlines = ParseInlineText(contents);
            paragraph.Inlines.AddRange(inlines);
            // This call is intended to push an entire stand-alone block, so we first push the
            // paragraph, then we push null to force a new block.
            CurrentBlock = paragraph;
            CurrentBlock = null;

            return this;
        }
        /// <summary>
        /// Images are added by reference to a desired image directory, such as
        ///     camp\cabin
        /// which may contain images the UI may choose to display.  The path is
        /// rootless as it's up to the UI to decide where exactly the images are stored
        /// or taken from.
        /// </summary>
        /// <returns>The ISceneDocument the image has been added to.</returns>
        public ISceneDocument NewImage(string imageRef)
        {
            Image image = ImageManager.GetImage(imageRef);
            if (image != null)
            {
                image.Width = 400;

                // Images are intended to be an entire block, so we first push the image, then
                // we push null to force a new block.
                CurrentBlock = new BlockUIContainer(image);
                CurrentBlock = null;
            }

            return this;
        }
        /// <summary>
        /// Adds a scene document as a section of the current scene document.
        /// </summary>
        /// <param name="sceneDocument">The ISceneDocument to be added as a section to the current ISceneDocument.</param>
        /// <returns>The ISceneDocument the sceneDocument has been added to.</returns>
        public ISceneDocument AddSection(ISceneDocument sceneDocument)
        {
            if (sceneDocument.Description is FlowDocument doc)
            {
                var section = new Section();

                // FlowDocument elements can only belong to one owner, so wtf must ensue.
                var from = doc;
                var ms = new MemoryStream();
                XamlWriter.Save(from, ms);
                ms.Position = 0;
                var fd = (FlowDocument)XamlReader.Load(ms);

                var blocks = new List<Block>();
                foreach (var block in fd.Blocks)
                {
                    blocks.Add(block);
                }
                section.Blocks.AddRange(blocks);

                // Sections are intended to be an entire block, so we first push the section, then
                // we push null to force a new block.
                CurrentBlock = section;
                CurrentBlock = null;

                return this;
            }
            throw new System.ArgumentException();
        }
        /// <summary>
        /// Adds a section to the scene document that can be mutated later.
        /// </summary>
        /// <param name="sectionKey">The key with which to access this particular section.</param>
        /// <returns>The ISceneDocument the mutable section has been added to.</returns>
        public ISceneDocument AddMutableSection(string sectionKey)
        {
            var section = new Section();
            mutableSections.Add(sectionKey, section);
            // Mutable sections are intended to be an entire empty block, so we first push the section,
            // then we push null to force a new block.
            CurrentBlock = section;
            CurrentBlock = null;

            return this;
        }
        /// <summary>
        /// Replaces the contents of a mutable section.  The replacement should be the `Description`
        /// from another `ISceneDocument`.
        /// </summary>
        /// <param name="key">The key to access the previously created mutable section.  Section will be
        ///                   created if it doesn't already exist.</param>
        /// <param name="replacement">The replacement contents. Should be the `Description` from
        ///                           another `ISceneDocument`.</param>
        /// <returns>The ISceneDocument the mutable section is a part of.</returns>
        public ISceneDocument MutateSection(string sectionKey, object replacement)
        {
            var section = mutableSections[sectionKey];
            if (section != null)
            {
                section.Blocks.Clear();
            }
            else
            {
                // Be nice and add the section if it doesn't exist.
                section = new Section();
                mutableSections[sectionKey] = section;
                CurrentBlock = section;
                CurrentBlock = null;
            }

            // FlowDocument elements can only belong to one owner, so wtf must ensue.
            var from = (FlowDocument)replacement;
            var ms = new MemoryStream();
            XamlWriter.Save(from, ms);
            ms.Position = 0;
            var fd = (FlowDocument)XamlReader.Load(ms);

            var blocks = new List<Block>();
            foreach (var block in fd.Blocks)
            {
                blocks.Add(block);
            }
            section.Blocks.AddRange(blocks);

            return this;
        }
        #endregion Block Elements

        #region Inline Elements
        // A note about inline elements: like in HTML, all whitespace is converted to a single space.
        // The reason for this is so that you can type strings across multiple lines for readability, instead
        // of either having one long string extending off the edge of the screen (if word wrap is off) or
        // needing to make multiple calls to add text and manage your end/beginning-of-line spaces appropriately.

        // Interpreters should also be sure to convert <i></i>, <b></b>, and <u></u> pairs into italic, bold,
        // and underline text, respectively.  Additionally, <br/> should be recognized as a LineBreak and <p></p>
        // should be recognized as paragraph delimeters.

        /// <summary>
        /// Helper function for adding inline elements.  Checks that we've got a valid
        /// block type to add to, corrects it if not, and adds the inline to the block.
        /// </summary>
        /// <param name="inline">The inline element to add.</param>
        protected void AddInline(Inline inline)
        {
            if (!(CurrentBlock is Paragraph))
            {
                CurrentBlock = new Paragraph();
            }
            (CurrentBlock as Paragraph).Inlines.Add(inline);
        }
        /// <summary>
        /// Helper function for adding inline elements.  Checks that we've got a valid
        /// block type to add to, corrects it if not, and adds the inlines to the block.
        /// </summary>
        /// <param name="inlines">A list of inline elements to add.</param>
        protected void AddInlines(List<Inline> inlines)
        {
            if (!(CurrentBlock is Paragraph))
            {
                CurrentBlock = new Paragraph();
            }
            (CurrentBlock as Paragraph).Inlines.AddRange(inlines);
        }

        #region Inline Images
        /// <summary>
        /// Adds an image as part of a run of text.  The image is flowed inline
        /// with the text; the text does not wrap around it.  You probably don't want
        /// this since image pack contents sizes are out of your control.
        /// </summary>
        /// <param name="imageRef">Generic path spec for the image.</param>
        /// <returns>The ISceneDocument the inline image has been added to.</returns>
        public ISceneDocument AddInlineImage(string imageRef)
        {
            var image = ImageManager.GetImage(imageRef);
            if (image != null)
            {
                var inlineImage = new InlineUIContainer(image);
                AddInline(inlineImage);
            }
            return this;
        }
        /// <summary>
        /// Adds an image as part of a run of text.  The image is flowed inline
        /// with the text; the text does not wrap around it.
        /// </summary>
        /// <param name="imageRef">Generic path spec for the image.</param>
        /// <param name="width">How wide, in pixels, you want the image to be. Not guaranteed to be paid attention to.</param>
        /// <returns>The ISceneDocument the inline image has been added to.</returns>
        public ISceneDocument AddInlineImage(string imageRef, int width)
        {
            var image = ImageManager.GetImage(imageRef);
            if (image != null)
            {
                image.Width = width;
                var inlineImage = new InlineUIContainer(image);
                AddInline(inlineImage);
            }
            return this;
        }
        /// <summary>
        /// Adds an image as part of a run of text.  The image is flowed inline
        /// with the text; the text does not wrap around it.
        /// </summary>
        /// <param name="imageRef">Generic path spec for the image.</param>
        /// <param name="alignment">Which side of the page or column you want the image anchored to.</param>
        /// <returns>The ISceneDocument the inline image has been added to.</returns>
        public ISceneDocument AddFigureImage(string imageRef, HorizontalAlignment alignment)
        {
            return AddFigureImage(imageRef, alignment, DefaultImageWidth, DefaultFigureUnitType);
        }
        /// <summary>
        /// Adds an image as part of a run of text.  The image is flowed inline
        /// with the text; the text does not wrap around it.
        /// </summary>
        /// <param name="imageRef">Generic path spec for the image.</param>
        /// <param name="alignment">Which side of the page or column you want the image anchored to.</param>
        /// <param name="width">How wide relative to the document display width (0-1) you want the image to be.
        ///                     Not guaranteed to be paid attention to.</param>
        /// <returns>The ISceneDocument the inline image has been added to.</returns>
        public ISceneDocument AddFigureImage(string imageRef, HorizontalAlignment alignment, double width)
        {
            return AddFigureImage(imageRef, alignment, width, DefaultFigureUnitType);
        }
        /// <summary>
        /// Adds an image as part of a run of text.  The image is flowed inline
        /// with the text; the text does not wrap around it.
        /// </summary>
        /// <param name="imageRef">Generic path spec for the image.</param>
        /// <param name="alignment">Which side of the page or column you want the image anchored to.</param>
        /// <param name="width">How wide relative to the document display width (0-1) you want the image to be.
        ///                     Not guaranteed to be paid attention to.</param>
        /// <returns>The ISceneDocument the inline image has been added to.</returns>
        public ISceneDocument AddFigureImage(string imageRef, HorizontalAlignment alignment, double width, System.Windows.FigureUnitType unitType)
        {
            var image = ImageManager.GetImage(imageRef);
            if (image != null)
            {
                var inlineImage = new BlockUIContainer(image);
                var figure = new Figure(inlineImage);
                figure.Width = new System.Windows.FigureLength(width, unitType);
                switch (alignment)
                {
                    case HorizontalAlignment.Left:
                        figure.HorizontalAnchor = System.Windows.FigureHorizontalAnchor.ColumnLeft;
                        break;
                    case HorizontalAlignment.Right:
                        figure.HorizontalAnchor = System.Windows.FigureHorizontalAnchor.ColumnRight;
                        break;
                    default:
                        break;
                }
                AddInline(figure);
            }
            return this;
        }
        #endregion Inline Images

        /// <summary>
        /// Add a linebreak to the current block.
        /// </summary>
        /// <returns></returns>
        public ISceneDocument AddLineBreak()
        {
            AddInline(new LineBreak());
            return this;
        }

        /// <summary>
        /// Add text to the current paragraph.  Tags *must* be closed - you can't break them across multiple calls.
        /// </summary>
        /// <param name="text">The text to be added.</param>
        public ISceneDocument AddText(string text)
        {
            // This is not going to be easy, since eventually we're going to have to deal with incomplete tag sets.
            // First implementation: Assume they're complete.
            var inlines = ParseInlineText(text);
            AddInlines(inlines);
            return this;
        }

        // For scenes that need to take some user input.
        public ISceneDocument AddInputBox(string key)
        {
            var textbox = new TextBox();
            textbox.Width = 250;
            textboxes.Add(key, textbox);
            var inline = new InlineUIContainer(textbox);
            inline.BaselineAlignment = System.Windows.BaselineAlignment.TextBottom;
            AddInline(inline);
            return this;
        }

        // Let the player select from a list.
        // Example: Pre-made characters on the character creation screen.
        public ISceneDocument AddComboBox(IList<string> list, string key)
        {
            var combobox = new ComboBox
            {
                IsEditable = false,
                ItemsSource = list,
                Width = 200,
            };
            comboboxes.Add(key, combobox);
            var inline = new InlineUIContainer(combobox);
            inline.BaselineAlignment = System.Windows.BaselineAlignment.TextBottom;
            AddInline(inline);
            return this;
        }
        #endregion Inline Elements

        // TODO: Better exception.
        /// <summary>
        /// Returns the resulting description as an object.
        /// 
        /// Should throw a "FormatException" if any `BeginSomething` hasn't been paired with it's `EndSomething`.
        /// And yes, I know that's not what that exception is intended for.  See above TODO.
        /// </summary>
        public object Description
        {
            get
            {
                if (CurrentBlock != null)
                {
                    CurrentBlock = null;
                }
                return document;
            }
        }
        #endregion ISceneDocument Implementation

        protected List<Inline> ParseInlineText(string text)
        {
            // For now we're assuming it'll work.  If there's missing text, this is probably why.
            return ParseInlineText(text, out _);
        }

        protected List<Inline> ParseInlineText(string text, out bool incompleteTags)
        {
            incompleteTags = false;
            try
            {
                var inlines = TextParser.TextToInlines(text);
                return inlines;
            }
            catch (Exception)
            {
                incompleteTags = true;
            }
            return new List<Inline>();
        }

        public FlowDocument DescriptionAsFlowObject
        {
            get => (FlowDocument)Description;
        }
        public Dictionary<string, TextBox> Textboxes => textboxes;
        public Dictionary<string, ComboBox> Comboboxes => comboboxes;
        public Dictionary<string, Section> MutableSections => mutableSections;

        public SceneFlowDocument(ImageManager imageManager)
        {
            ImageManager = imageManager;
            document = new FlowDocument()
            {
                TextAlignment = System.Windows.TextAlignment.Left,
                FontFamily = new System.Windows.Media.FontFamily("Global Serif"),
                FontSize = 20,
            };
            textboxes = new Dictionary<string, TextBox>();
            comboboxes = new Dictionary<string, ComboBox>();
            mutableSections = new Dictionary<string, Section>();
        }
    }
}