using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Xml.Linq;

namespace CoC_Desktop_WPF.Utilities
{
    class SceneTextToFlowDocument : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string source)
            {
                var xhtml = "<Section>" + source + "</Section>";
                XElement xml = XElement.Parse(xhtml);
                foreach (var node in xml.DescendantNodes())
                {
                    if (node is XElement element)
                    {
                        switch (element.Name.LocalName.ToLowerInvariant())
                        {
                            case "u":
                                element.Name = "Underline";
                                break;
                            case "b":
                            case "strong":
                                element.Name = "Bold";
                                break;
                            case "i":
                            case "em":
                                element.Name = "Italic";
                                break;
                            case "p":
                                element.Name = "Paragraph";
                                break;
                            default:
                                break;
                        }
                    }
                }

                ParserContext context = new ParserContext();
                context.XmlnsDictionary.Add("", "http://schemas.microsoft.com/winfx/2006/xaml/presentation");
                return new FlowDocument((Section)XamlReader.Parse(xml.ToString(),context));
            }
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
