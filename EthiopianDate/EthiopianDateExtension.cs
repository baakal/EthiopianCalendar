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
        public static string ToEthiopianDateString(this DateTime dateTime,string format)
        {
            var ethiopianDate = new EthiopianDate(dateTime);
            return ethiopianDate.ToString(format);
        }
        public static EthiopianDate ToEthiopianDate(this DateTime dateTime)
        {
           return new EthiopianDate(dateTime);  
        }
        
    }
}