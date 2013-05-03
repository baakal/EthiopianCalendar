using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaakalDate
{
    public struct EthiopianDate
    {
        public int Month;

        public int Year;

        public int Day;

        public EthiopianDate (int day,int month,int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }

        public EthiopianDate(DateTime dateTime)
        {
            EthiopianDate ethiopianDate = EthiopianDateConverter.ToEthiopianDate(dateTime);
            Month = ethiopianDate.Month;
            Day = ethiopianDate.Day;
            Year = ethiopianDate.Year;
        }

        public override string ToString()
        {
            return ToString("dd/mm/yyyy");
        }

        public  string ToString(string format)
        {
            return EthiopianDateFormat.Format(this, format);
        }

        public String ToLongDate()
        {
            return ToString("mmm dd,yyyy");
        }
   
        public string ToShortDate()
        {
            return ToString("dd/mm/yy");
        }
    }
}
