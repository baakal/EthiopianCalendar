using System;
using System.Drawing;

namespace EthiopianCalendar.Conversion
{
    public class EthiopianDateConverter
    {
        private const int JdOffset = 1723856;
     
        #region To Ethiopian Date
        
        public static  EthiopianDate ToEthiopianDate(int jdn)
        {
            //Formula from Dr. Berhanu Beyene and Manfred Kudlek
            int year, month, day,r,n;

           
            r = (jdn - JdOffset) % 1461;
            n = r%365 + 365*(r/1460);

            year = 4 * ((jdn - JdOffset) / 1461) + r / 365 - r / 1460;
            month = n/30 + 1;
            day = n%30 + 1;
            return new EthiopianDate(year,month,day);
            
        }
        
        public static EthiopianDate ToEthiopianDate(DateTime dateTime)
        {
            int jdn = ToJDN(dateTime);
            return ToEthiopianDate( jdn);
           
        }

        public static int ToJDN(DateTime dateTime)
        {
            int a, y, m;
            a = (14 - dateTime.Month)/12;
            y = dateTime.Year + 4800 - a;
            m = dateTime.Month + 12 * a - 3;

            return dateTime.Day + (153 * m + 2)/5 + 365 * y + y/4 - y / 100 + y /400 - 32045;
        }
        
        #endregion
        
        #region To Gregorian Date
       
        public static   DateTime ToGregorianDate(int jdn)
        {
           int year, month, day;

           int r = jdn + 68569;
           int n = 4*r/146097;
          
            r = r - (146097*n + 3)/4;
            year = 4000*(r + 1)/1461001;
            r = r - 1461*year/4 + 31;
            month = 80*r/2447;
            day = r - 2447*month/80;
            r = month/11;
            month = month + 2 - 12*r;
            year = 100*(n - 49) + year + r;
 
            return new DateTime(year,month,day);
        }
       
        public static DateTime ToGregorianDate(int year, int month, int day)
        {
            int jdn = FromEthiopianDateToJDN(year, month, day);
            return ToGregorianDate(jdn);
        }

        private static int FromEthiopianDateToJDN(int year, int month, int day)
        {
            return (JdOffset + 365) + 365 * (year - 1) + year / 4 + 30 * month +
                day - 31;
        }
  
        public static int ToJDN(EthiopianDate ethiopianDate)
        {
            return FromEthiopianDateToJDN(ethiopianDate.Year, ethiopianDate.Month, ethiopianDate.Day);
        }

        #endregion


    }
}