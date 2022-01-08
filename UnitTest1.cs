using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fiboTest
{
    [TestClass]
    public class Program
    {
        [TestMethod]
    
        public void TestMethod1()
        {
            Program p = new Program();
            double res = p.Fibo(8);
            Assert.AreEqual(res, "0 1 1 2 3 5 8 13");
        }
    
    }
}
