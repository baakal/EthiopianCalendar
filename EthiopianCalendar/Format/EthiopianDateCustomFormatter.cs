using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EthiopianCalendar.Format
{
    public class EthiopianDateCustomFormatter:ICustomFormatter
    {
        static readonly string[] Months = { "Unknown Months", "መስከረም", "ጥቅምት", "ኅዳር", "ታኅሣሥ", "ጥር", "የካቲት", "መጋቢት", "ሚያዝያ", "ግንቦት", "ሰኔ", "ሐምሌ", "ነሐሴ", "ጳጉሜን" };

        private static readonly string[] DayOfWeek = {"እሑድ", "ሰኞ", "ማክሰኞ", "ረቡዕ", "ሓሙስ", "ዓርብ", "ቅዳሜ"};
      
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            EthiopianDate ethiopianDate;
           if(arg is DateTime)
           {            
               DateTime dateTime = (DateTime) arg;
               ethiopianDate = dateTime.ToEthiopianDate();
           }
           else if (arg is EthiopianDate)
           {
               ethiopianDate = (EthiopianDate) arg;
           }
           else
           {
               throw new FormatException();
           }
               format = format.Replace("MMMM", Months[ethiopianDate.Month]);
               format = format.Replace("MM", ethiopianDate.Month.ToString("00"));
               format = format.Replace("M", ethiopianDate.Month.ToString());

               format = format.Replace("ddd", DayOfWeek[ethiopianDate.DayOfWeek]);
               format = format.Replace("dd", ethiopianDate.Day.ToString("00"));
               format = format.Replace("d", ethiopianDate.Day.ToString());

               format = format.Replace("yyyyy", ethiopianDate.Year.ToString("00000"));
               format = format.Replace("yyyy", ethiopianDate.Year.ToString("0000"));
               format = format.Replace("yy", (ethiopianDate.Year%1000).ToString("00"));
               format = format.Replace("y", (ethiopianDate.Year%1000).ToString());
    
            return format;
        }
    }
}
