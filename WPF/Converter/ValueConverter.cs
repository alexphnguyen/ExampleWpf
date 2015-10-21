using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace WPF.Converter {

  // A converter takes a value, parses it, and returns another value.
  // For example, the visibility of a control may depend on a boolean.
  // The color of a control may depend on a hex.
  // If a list is empty you may wish to make it disappear instead of displaying an empty box.
  // Converters allow for more complex behavior.
  // IValueConverter is standard to converters.
  // MarkupExtension enables using a converterter without making it a "StaticResource".
  // http://www.codeproject.com/Articles/35416/Use-of-MarkupExtension-with-Converters-in-WPF

  public abstract class BaseConverter : MarkupExtension, IValueConverter {
    public override object ProvideValue(IServiceProvider serviceProvider) {
      return this;
    }
    public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);
    public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
  }

  public class ConverterUtilities {
    public static bool Inverted(object parameter) {
      var parameterString = parameter as string;
      var inverted = parameterString != null && parameterString == "Inverted";
      return inverted;
    }
  }

  public class NotNullToVisible : BaseConverter {
    public NotNullToVisible() { }
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
      var isValueNull = value == null;
      return (isValueNull ^ ConverterUtilities.Inverted(parameter)) ? Visibility.Collapsed : Visibility.Visible;
    }

    public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
      throw new NotImplementedException();
    }
  }
}
