using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemoApp.Convertors
{
    class EligibityConverters : ivalueconverter
    {
        int _age;
        public object convert(object value, Type targetType, object parameter, culterInfo culture)
        {
            _age = (int)value;
            if (_age > 17)
            {
                return "Eligible";
            }
            return "Not Eligible";

        }
    }
}
