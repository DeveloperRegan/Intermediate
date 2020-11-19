using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPR.StopWatch.BL;

namespace TPR.StopWatch.Test.BL
{
    [TestClass]
    public class TimeTest
    {
        [TestMethod]
        public void StartTimeNotNull()
        {
            Watch w = new Watch();
            Assert.IsNotNull(w.startTime);
        }
        [TestMethod]
        public void SpeedTimeAssignment()
        {
            Watch w = new Watch();
            w.startTime = DateTime.Now;
            w.stopTime = DateTime.Now;
            Assert.AreNotEqual(w.startTime, w.stopTime);
        }
    }
}
