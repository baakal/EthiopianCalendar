using System;

namespace EthiopianCalendar.Period
{
    public struct Period
    {
        private string _name;
        private DateTime _fromDateTime;
        private DateTime _toDateTime;

        public string Name
        {
            get { return _name; }
        }

        public DateTime FromDateTime
        {
            get { return _fromDateTime; }
        }

        public DateTime ToDateTime
        {
            get { return _toDateTime; }

        }

        public Period(string name, DateTime fromDateTime, DateTime toDateTime)
        {
            _name = name;
            _fromDateTime = fromDateTime;
            _toDateTime = toDateTime;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}