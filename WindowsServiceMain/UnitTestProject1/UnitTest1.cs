using System;
using Logger2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Logger2.Logger2 logger = new Logger2.Logger2();
        [TestMethod]
        public void TestMethod1()
        {
            
        }
        [TestMethod]
       // [Timeout(4000)]
        public void CpuReturnTest()
        {

            Assert.IsTrue(0 <= logger.GetCpuValue(), "The CpuValue is smaller than zero");
            Assert.IsTrue(100 >= logger.GetCpuValue(), "The CpuValue is greater than 100");
        }
        [TestMethod]
       // [Timeout(4000)]
        public void MemReturnTest()
        {

            Assert.IsTrue(0 <= logger.GetMemValue(), "The MemValue is smaller than zero");
            Assert.IsTrue(100 >= logger.GetMemValue(), "The MemuValue is greater than 100");
        }
    }
}
