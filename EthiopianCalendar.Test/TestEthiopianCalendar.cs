using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace EthiopianCalendar.Test
{
    [TestClass]
    public class TestEthiopianCalendar
    {
        [TestMethod]
        public void TestToDateTime()
        {
            DateTime dateTime = new DateTime(2012,9,8);
            EthiopianCalendar ethiopianCalendar = new EthiopianCalendar();
            ethiopianCalendar.ToDateTime(2012, 9, 8, 0, 0, 0, 0);
            
        }
    }
}
