using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace CoC_Desktop_WPF.Utilities
{
    class HpStatToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is CoC_Lib.Characters.Statistics.HpStat hpStat)
            {
                var r = (1 - (hpStat.Value / (float)hpStat.Maximum)) * 0.8f;
                var g = (hpStat.Value / (float)hpStat.Maximum) * 0.8f;
                var b = 0.0f;
                return new SolidColorBrush(Color.FromScRgb(1, r, g, b));
            }
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
