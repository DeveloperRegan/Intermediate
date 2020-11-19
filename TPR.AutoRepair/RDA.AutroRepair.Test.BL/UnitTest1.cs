using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPR.AutoRepair.BL;

namespace TPR.AutroRepair.Test.BL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CarConstructorTest()
        {
            Car c = new Car();

            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void CarConstructorTest2()
        {
            Car c = new Car("Ford", "Taurus", 2007);

            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void CarCompare()
        {
            Car c = new Car("Ford", "Taurus", 2007);
            Car c2 = new Car("Ford", "Taurus", 2007);

            Assert.AreNotSame(c, c2);
        }
    }
}
