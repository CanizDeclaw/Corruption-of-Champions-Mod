using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Xml.Linq;

namespace CoC_Desktop_WPF.Utilities
{
    public static class FlowDocumentConverters
    {
        public static readonly string Xmlns = "http://schemas.microsoft.com/winfx/2006/xaml/presentation";

        //public static Section HtmlToSection(string html)
        //{
        //    var xhtml = "<Section>" + html + "</Section>";
        //    XElement xml = XElement.Parse(xhtml);
        //    foreach (var node in xml.DescendantNodes())
        //    {
        //        if (node is XElement element)
        //        {
        //            switch (element.Name.LocalName.ToLowerInvariant())
        //            {
        //                case "u":
        //                    element.Name = "Underline";
        //                    break;
        //                case "b":
        //                case "strong":
        //                    element.Name = "Bold";
        //                    break;
        //                case "i":
        //                case "em":
        //                    element.Name = "Italic";
        //                    break;
        //                case "p":
        //                    element.Name = "Paragraph";
        //                    break;
        //                case "img":
        //                    element = HtmlImageToFlowDocumentImage(element);
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //    }

        //    ParserContext context = new ParserContext();
        //    context.XmlnsDictionary.Add("", Xmlns);
        //    return (Section)XamlReader.Parse(xml.ToString(), context);
        //}

        //public static Section HtmlToFlowDocument(string html)
        //{
        //    // Hooray for state machines.

        //    var fd = new FlowDocument();
        //    return (Section)XamlReader.Parse(xml.ToString(), context);
        //}

        //private static XElement HtmlImageToFlowDocumentImage(XElement element)
        //{
        //    var image = new Image();
        //    var buic = new BlockUIContainer(image);
        //    var f = new Floater(buic);
        //    return xam f.;
        //}
    }
}
