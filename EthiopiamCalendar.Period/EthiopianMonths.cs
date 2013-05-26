using System;
using System.Collections.Generic;

namespace EthiopianCalendar.Period
{
    public class EthiopianMonths
    {
        private IList<Period> _periods;

        private int _year;
        public EthiopianMonths()
        {
            _year = DateTime.Now.Year;
        }

        public EthiopianMonths(int year)
        {
            _year = year;

        }

        public IList<Period> BuildEthiopianDate()
        {
            EthiopianDate fromDate;
            EthiopianDate toDate;
            _periods = new List<Period>();
            for (int i = 1; i <= 12; i++)
            {
                fromDate = new EthiopianDate(_year, i, 01);
                toDate = new EthiopianDate(_year, i, 30);
                _periods.Add(new Period(fromDate.ToString("mmm"), fromDate.DateTime, toDate.DateTime));

            }

            fromDate = new EthiopianDate(_year, 13, 01);
            toDate = new EthiopianDate(_year, 13, 5);

            _periods.Add(new Period(fromDate.ToString("mmm"), fromDate.DateTime, toDate.DateTime));
            return _periods;
        }

        public IList<Period> period
        {
            get { return _periods; }
        }


    }
}
