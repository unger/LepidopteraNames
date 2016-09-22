using System;
using System.Collections;
using System.Globalization;
using Xamarin.Forms;

namespace LepidopteraNames.Converters
{
    public class DataSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = ((IList) value);
            return val == null || val.Count == 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
