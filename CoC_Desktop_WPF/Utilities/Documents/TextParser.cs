using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace CoC_Desktop_WPF.Utilities.Documents
{
    public static class TextParser
    {
        private struct Tag
        {
            public string Open;
            public string Close;
            public bool SelfClosing;

            public Tag(string open, string close, bool selfClosing)
            {
                Open = open;
                Close = close;
                SelfClosing = selfClosing;
            }
        }

        private class ParserObject { }
        private class TextRun : ParserObject
        {
            public string Text;
            public TextRun(string text)
            {
                Text = text;
            }
        }
        private class ParserTag : ParserObject
        {
            public Tag Tag;
        }
        private class StartTag : ParserTag
        {
            public StartTag(Tag tag)
            {
                Tag = tag;
            }
        }
        private class EndTag : ParserTag
        {
            public EndTag(Tag tag)
            {
                Tag = tag;
            }
        }
        private class SelfClosingTag : ParserTag
        {
            public SelfClosingTag(Tag tag)
            {
                Tag = tag;
            }
        }

        private static Tag[] tags = new Tag[]
        {
            new Tag("<b>", "</b>", false),
            new Tag("<i>", "</i>", false),
            new Tag("<u>", "</u>", false),
            new Tag("<br>", "", true), // Being generous with this one.
            new Tag("<br/>", "", true),
            new Tag("<br />", "", true),
        };
        private static char tagOpen = '<';
        private static char tagClose = '>';

        private static string CompactWhitespace(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                if (char.IsWhiteSpace(c))
                {
                    sb.Append(' ');
                    i++;
                    while (i < text.Length && char.IsWhiteSpace(text[i]))
                    {
                        i++;
                    }
                    i--; // So the for loop puts us at the right spot.
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
        private static List<string> SplitOnTags(string text)
        {
            var strings = new List<string>();
            // We use these to grab the final substring after the loop, so they have
            // to be external to it.
            int currentIndex = 0;
            int substringStart = currentIndex;
            bool inTag = false;
            for (; currentIndex < text.Length; currentIndex++)
            {
                // Skip out early if not a split token.
                var c = text[currentIndex];
                if (c != tagOpen && c != tagClose)
                {
                    continue;
                }
                else if (c == tagClose && inTag == false)
                {
                    // can't close if there's nothing open.
                    continue;
                }

                // Figure out the substring boundaries and whether or not we're now in a tag.
                int modifier = 0;
                if (inTag == true)
                {
                    if (c == tagOpen)
                    {
                        modifier = 0; // not-tag candidates should not include the tag opener.
                        // inTag stays true;
                    }
                    else if (c == tagClose)
                    {
                        modifier = 1; // tag candidates should include the tag closer.
                        inTag = false;
                    }
                }
                else // Not in tag and not tagClose (excluded by earlier `continue` `if`s).
                {
                    modifier = 0; // not-tag candidates should not include the tag opener.
                    inTag = true;
                }

                // Get the substring, add it to the list, and start from the new position.
                var str = text.Substring(substringStart, currentIndex - substringStart + modifier);
                if (str != string.Empty)
                {
                    strings.Add(str);
                }
                substringStart = currentIndex + modifier;
            }
            // Get the final substring.
            var final = text.Substring(substringStart, currentIndex - substringStart);
            if (final != string.Empty)
            {
                strings.Add(final);
            }

            return strings;
        }
        private static List<ParserObject> FixTags(List<string> strings)
        {
            List<ParserObject> Output = new List<ParserObject>();
            Stack<ParserTag> OpenTags = new Stack<ParserTag>();

            foreach (var str in strings)
            {
                ParserTag tag = GetTag(str);
                if (tag == null)
                {
                    Output.Add(new TextRun(str));
                    continue;
                }

                if (tag is SelfClosingTag)
                {
                    Output.Add(tag);
                }
                else if (tag is StartTag)
                {
                    OpenTags.Push(tag);
                    Output.Add(tag);
                }
                else if (tag is EndTag)
                {
                    bool matchFound = false;
                    Stack<ParserTag> oTags = new Stack<ParserTag>();
                    while (OpenTags.Count > 0)
                    {
                        var oTag = OpenTags.Pop();
                        if (oTag.Tag.Open == tag.Tag.Open)
                        {
                            Output.Add(tag);
                            matchFound = true;
                            break;
                        }
                        oTags.Push(oTag);
                        Output.Add(new EndTag(oTag.Tag));
                    }
                    if (matchFound == false)
                    {
                        throw new ArgumentException();
                    }
                    foreach (var oTag in oTags)
                    {
                        Output.Add(oTag);
                    }
                }
            }
            if (OpenTags.Count > 0)
            {
                throw new ArgumentException();
            }

            return Output;
        }
        private static List<Inline> ParserObjectsToInlines(List<ParserObject> parserObjects)
        {
            var inlines = new List<Inline>();

            // Recursive!
            for (int i = 0; i < parserObjects.Count; i++)
            {
                var po = parserObjects[i];
                if (po is TextRun run)
                {
                    inlines.Add(new Run(run.Text));
                }
                else if (po is SelfClosingTag)
                {
                    // Only valid self-closing tag right now is a linebreak, so no test.
                    inlines.Add(new LineBreak());
                }
                else if (po is StartTag start)
                {
                    // The only tag-pairs we have right now are Span-type inlines.
                    var inline = GetSpan(start);

                    // FixTags should have already been called to make sure we're not going
                    // to have unbalanced or overlapping pairs.
                    int openTags = 0;
                    for (int j = i+1; j < parserObjects.Count; j++)
                    {
                        var obj = parserObjects[j];
                        if (obj is TextRun)
                        {
                            continue;
                        }
                        else if (obj is StartTag)
                        {
                            openTags++;
                            continue;
                        }
                        else if (obj is EndTag endTag)
                        {
                            if (openTags > 0)
                            {
                                openTags--;
                            }
                            else
                            {
                                var subset = parserObjects.GetRange(i + 1, j - i - 1); // Skip this start and end tag.
                                inline.Inlines.AddRange(ParserObjectsToInlines(subset));
                                inlines.Add(inline);
                                i = j;
                            }
                        }
                    }
                }
            }

            return inlines;
        }

        private static ParserTag GetTag(string str)
        {
            var lowered = str.ToLowerInvariant();
            foreach (var tag in tags)
            {
                if (tag.SelfClosing == true)
                {
                    if (lowered == tag.Open)
                    {
                        return new SelfClosingTag(tag);
                    }
                }
                else
                {
                    if (lowered == tag.Open)
                    {
                        return new StartTag(tag);
                    }
                    else if (lowered == tag.Close)
                    {
                        return new EndTag(tag);
                    }
                }
            }
            return null;
        }

        private static Span GetSpan(StartTag start)
        {
            switch (start.Tag.Open)
            {
                case "<b>":
                    return new Bold();
                case "<i>":
                    return new Italic();
                case "<u>":
                    return new Underline();
                default:
                    throw new ArgumentException();
            }
        }

        public static List<Inline> TextToInlines(string text)
        {
            text = CompactWhitespace(text);
            var strings = SplitOnTags(text);
            var parserObjects = FixTags(strings);
            var inlines = ParserObjectsToInlines(parserObjects);
            return inlines;
        }
    }
}
