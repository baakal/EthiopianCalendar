using System;
using System.Globalization;
using EthiopianCalendar.Conversion;

namespace EthiopianCalendar
{
    public class EthiopianCalendar:Calendar
    {
        #region Properties

        public override CalendarAlgorithmType AlgorithmType
		{
			get { return CalendarAlgorithmType.LunisolarCalendar; }
		}

		
		public override int[] Eras
		{
			get { return new int[] { 0,1 }; }
		}

			
        public override DateTime MinSupportedDateTime
		{
			get { return  new DateTime(1800, 1, 25,0,0,0,this); }
		}

        public override DateTime MaxSupportedDateTime
		{
			get { return new DateTime(2199, 12, 31, 23, 59, 59,this); }
		}


       #endregion

        #region Overrides of Calendar

        public override DateTime AddMonths(DateTime time, int months)
        {
            int month = time.Month + months;
             month = month%13;
            int year = time.Year + time.Month/13;
           
            return new DateTime(year, month,time.Day,this);
        }

        public override DateTime AddYears(DateTime time, int years)
        {
            throw new NotImplementedException();
        }

        public override int GetDayOfMonth(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override DayOfWeek GetDayOfWeek(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override int GetDayOfYear(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override int GetDaysInMonth(int year, int month, int era)
        {
            throw new NotImplementedException();
        }

        public override int GetDaysInYear(int year, int era)
        {
            throw new NotImplementedException();
        }

        public override int GetEra(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override int GetMonth(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override int GetMonthsInYear(int year, int era)
        {
            throw new NotImplementedException();
        }

        public override int GetYear(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override bool IsLeapDay(int year, int month, int day, int era)
        {
            throw new NotImplementedException();
        }

        public override bool IsLeapMonth(int year, int month, int era)
        {
            throw new NotImplementedException();
        }

        public override bool IsLeapYear(int year, int era)
        {
            throw new NotImplementedException();
        }

        public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
        {
            return EthiopianDateConverter.ToGregorianDate(year,month,day);
        }
        #endregion
    }
}
