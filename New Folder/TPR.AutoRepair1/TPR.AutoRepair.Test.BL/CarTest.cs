using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPR.AutoRepair.BL;

namespace TPR.AutoRepair.Test.BL
{
    [TestClass]
    public class CarTest
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
            Car c = new Car("a","b",1212);
        

            Assert.IsNotNull(c);
        }
        [TestMethod]
        public void CarCompare()
        {
            Car c = new Car("a", "b", 1212);
            Car c2 = new Car("a", "b", 1212);


            Assert.AreNotSame(c, c2);
        }
    }
}
