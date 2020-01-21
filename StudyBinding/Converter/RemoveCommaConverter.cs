using System;
using System.Globalization;
using Xamarin.Forms;

namespace StudyBinding.Converter
{
    public class RemoveCommaConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString().Replace(",","");

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
