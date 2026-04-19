using System;
using System.Globalization;
using System.Windows.Data;

namespace Shoes.Classes
{
    public class ImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string file = value as string;

            if (string.IsNullOrWhiteSpace(file))
                return "/Res/Products/picture.png";

            return new Uri($"pack://application:,,,/Res/Products/{file}", UriKind.Absolute);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}