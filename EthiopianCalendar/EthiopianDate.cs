using System;
using System.Runtime.Serialization;
using EthiopianCalendar.Conversion;
using EthiopianCalendar.Format;

namespace EthiopianCalendar
{
    public struct EthiopianDate : IComparable, IFormattable,
    IConvertible, ISerializable, IComparable<EthiopianDate>, IEquatable<EthiopianDate>
    {
        private int _year, _month, _day;

        public int Month { get { return _month; } }

        public int Year { get { return _year; } }

        public int Day { get { return _day; } }

        private DateTime _dateTime;
        
        public  DateTime DateTime {get { return new DateTime(_dateTime.Ticks); } }
        
        public EthiopianDate (int year,int month,int day)
        {
            _dateTime = EthiopianDateConverter.ToGregorianDate(year,month,day);
            _month = month;
            _day = day;
            _year = year;
        }

        public EthiopianDate(DateTime dateTime)
        {
            _dateTime = dateTime;
            EthiopianDate ethiopianDate = EthiopianDateConverter.ToEthiopianDate(dateTime);
            _month = ethiopianDate.Month;
            _day = ethiopianDate.Day;
            _year = ethiopianDate.Year;
        }

        public void FromGregorianDate(DateTime dateTime)
        {
            EthiopianDate ethiopianDate = EthiopianDateConverter.ToEthiopianDate(dateTime);
            _month = ethiopianDate.Month;
            _day = ethiopianDate.Day;
            _year = ethiopianDate.Year;
        }

        bool IEquatable<EthiopianDate>.Equals(EthiopianDate other)
        {
            return _dateTime.Equals(other._dateTime);
        }

        public override string ToString()
        {
            return ToString("dd/mm/yyyy");
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            ISerializable serializable = _dateTime;
            serializable.GetObjectData(info,context);
        }

        string IFormattable.ToString(string format, IFormatProvider formatProvider)
        {
            var formatter = (ICustomFormatter) formatProvider.GetFormat(typeof (ICustomFormatter));
            return formatter.Format(format, this, formatProvider);
        }

        int IComparable.CompareTo(object obj)
        {
            if (obj is EthiopianDate)
            {
                return ((IComparable<EthiopianDate>) this).CompareTo((EthiopianDate)obj);
            }
           return _dateTime.CompareTo(obj);
        }

        int IComparable<EthiopianDate>.CompareTo(EthiopianDate other)
        {
            return _dateTime.CompareTo(other._dateTime);
        }
        
        TypeCode IConvertible.GetTypeCode()
        {
            return Type.GetTypeCode(this.GetType());
        }
      
        public  string ToString(string format)
        {
            return EthiopianDateFormatProvider.FormatToEthiopianDate(this, format);
        }

        public String ToLongDateString()
        {
            return ToString("mmm dd,yyyy");
        }
   
        public string ToShortDateString()
        {
            return ToString("dd/mm/yy");
        }

        public DateTime ToGregorianDate()
        {
            return _dateTime;
        }

       
      
       
        #region Implementation of IConvertible
        
        public bool ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            return _dateTime;
        }

        public string ToString(IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new InvalidCastException();
        }

        #endregion
    }
}
