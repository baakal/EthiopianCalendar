using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaakalDate
{
    public class EthiopianDateFormat
    {
       static readonly string[] Months = {"Unknown Months", "mekerem", " tekemte", "hedar", "tahsas", "t'er", "yekatit", "megabit", "miazia", "genbot", "senei", "Hamlei", "Nehassei", "pagumein" };
           
        
        public static string Format(EthiopianDate ethiopianDate,string formatString)
        {
            formatString = formatString.Replace("mmm", Months[ethiopianDate.Month]);
            formatString = formatString.Replace("mm", ethiopianDate.Month.ToString("00"));
            formatString = formatString.Replace("m", ethiopianDate.Month.ToString());

            formatString = formatString.Replace("dd", ethiopianDate.Day.ToString("00"));
            formatString = formatString.Replace("d", ethiopianDate.Day.ToString());
            formatString = formatString.Replace("yyyy", ethiopianDate.Year.ToString());
            formatString = formatString.Replace("yy", (ethiopianDate.Year%1000).ToString("00"));
            
            return formatString;
        }

        
    }
}
