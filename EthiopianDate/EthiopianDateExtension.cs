using System;

namespace BaakalDate
{
    public static class EthiopianDateExtension
    {
       
        public static string ToEthiopianShortDateString(this DateTime dateTime)
        {
            var ethiopianDate = new EthiopianDate(dateTime);
            return ethiopianDate.ToShortDate();
        }
        
        public static string ToEthiopianLongDateString(this DateTime dateTime)
        {
            var ethiopianDate = new EthiopianDate(dateTime);
            return ethiopianDate.ToLongDate();
        }

        public static string ToEthiopianDateString(this DateTime dateTime,string format = "d/m/yyyy")
        {
            var ethiopianDate = new EthiopianDate(dateTime);
            return ethiopianDate.ToString(format);
        }
        
        public static EthiopianDate ToEthiopianDate(this DateTime dateTime)
        {
           return new EthiopianDate(dateTime);  
        }

        public static string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (arg == null) 
                throw new ArgumentNullException("arg");
            if (arg.GetType() != typeof(DateTime)) 
                return arg.ToString();

            DateTime date = (DateTime) arg;
                   if(format == "ethiopianDate")
                   {
                      return date.ToEthiopianLongDateString();
                   }
            return date.ToString(format,formatProvider);
        }

        public static string ToString(this DateTime d, string format, IFormatProvider formatProvider)
        {
            return Format(format, d, formatProvider);
        }

        public static string ToString( this DateTime d,string format)
        {
            return d.ToEthiopianDateString();
        }
        
    }
}