using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace AmadeusW.MessagePanelControl
{
    /// <summary>
    /// Converts MessageKind to a glyph in Wingdings font
    /// </summary>
    [ValueConversion(typeof(MessageKind), typeof(String))]
    public class KindToGlyphConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is MessageKind))
            {
                return " ";
            }
            switch ((MessageKind)value)
            {
                case MessageKind.Info:
                    return "w"; // a diamond
                case MessageKind.Fatal:
                    return "û"; // X icon
                case MessageKind.Error:
                    return "û"; // X icon
                case MessageKind.Warning:
                    return "w"; // a diamond
                case MessageKind.Success:
                    return "ü"; // a checkmark
                default:
                    return " ";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
