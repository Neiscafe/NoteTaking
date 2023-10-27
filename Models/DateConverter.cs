using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace NoteTaking.Models
{
    public class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var date = (DateTime)value;
            return (object)date.ToShortDateString;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var date = (string) value;
            return DateTime.Parse(date);
        }
    }
}
