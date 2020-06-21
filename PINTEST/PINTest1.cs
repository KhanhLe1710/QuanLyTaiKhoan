using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quan_ly_tai_khoan;

namespace PINTEST
{
    [TestClass]
    public class PINTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            fChangePIN obj = new fChangePIN();
            bool mapinhientai = obj.doimapin(1234, 1235);
            Assert.IsTrue(mapinhientai);
        }
    }
}
