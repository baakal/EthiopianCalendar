using System;

namespace EthiopianCalendar
{
    public static class EthiopianDateExtension
    {
       
        public static string ToEthiopianShortDateString(this DateTime dateTime)
        {
            var ethiopianDate = new EthiopianDate(dateTime);
            return ethiopianDate.ToShortDateString();
        }
        
        public static string ToEthiopianLongDateString(this DateTime dateTime)
        {
            var ethiopianDate = new EthiopianDate(dateTime);
            return ethiopianDate.ToLongDateString();
        }

        public static string ToEthiopianDateString(this DateTime dateTime,string format = "MMMM dd, yyyy")
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