using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EthiopianCalendar.Format
{
    public class EthiopianDateCustomFormatter:ICustomFormatter
    {

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
           if(arg is DateTime)
           {
               DateTime dateTime = (DateTime) arg;
               return dateTime.ToEthiopianDateString(format);
           }
            return arg.ToString();
        }
    }
}
