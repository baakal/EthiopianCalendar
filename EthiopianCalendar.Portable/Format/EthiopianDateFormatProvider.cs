using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthiopianCalendar.Format
{
    public class EthiopianDateFormatProvider:IFormatProvider
    {

        #region Implementation of IFormatProvider

        public object GetFormat(Type formatType)
        {
            return new EthiopianDateCustomFormatter();
        }

        #endregion
    }
}
