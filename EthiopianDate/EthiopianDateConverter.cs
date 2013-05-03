using System;
using System.Drawing;

namespace BaakalDate
{
    public class EthiopianDateConverter
    {
        
     
        #region To Ethiopian Date
        public static  EthiopianDate ToEthiopianDate(int jdn)
        {
            //Formula from Dr. Berhanu Beyene and Manfred Kudlek
            int year, month, day,jdOffset,r,n;

            jdOffset = 1723856;
            r = (jdn - jdOffset) % 1461;
            n = r%365 + 365*(r/1460);

            year = 4 * ((jdn - jdOffset) / 1461) + r / 365 - r / 1460;
            month = n/30 + 1;
            day = n%30 + 1;
            return new EthiopianDate(day,month,year);
            
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

        public static   DateTime ToGregorianDate(int JDN)
        {

            throw new NotImplementedException();
        }
       
        public static int ToJDN(EthiopianDate DateTime)
        {
            throw new NotImplementedException();        
        }

       

    }
}