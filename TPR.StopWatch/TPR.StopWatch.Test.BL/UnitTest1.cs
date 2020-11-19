using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPR.StopWatch.BL;
namespace TPR.StopWatch.Test.BL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Watch w = new Watch();
            w.startTime = DateTime.Now;
            int i = 5;
            w.stopTime = DateTime.Now;
            w.time();
            Watch w2 = new Watch();

            w.startTime = DateTime.Now;
            w.stopTime = DateTime.Now;
            w2.time();
            Assert.AreNotEqual(w.timePassed, w2.timePassed);
        }
        [TestMethod]
        public void timesDifferent()
        {
            Watch w = new Watch();
            w.startTime = DateTime.Now;
            w.stopTime = DateTime.Now;
            Assert.AreEqual(w.startTime, w.stopTime);
        }
    }
}
