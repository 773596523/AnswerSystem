using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using AnswerSystemWPF.Body;

namespace AnswerSystemWPF.Converter
{
    public class TopicStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Uri imgUri = new Uri("/Resources/Images/btn.png", UriKind.Relative);

            if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
            {
                imgUri = new Uri("/Resources/Images/btn2.png", UriKind.Relative);
            }

            return imgUri;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
