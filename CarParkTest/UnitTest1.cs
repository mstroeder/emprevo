using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarPark;
using System.Diagnostics;

namespace CarParkTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test8am12noon()
        {
            var rate = RateEngine.CalculateRate(new DateTime(2017, 2, 1, 8, 0, 0), new DateTime(2017, 2, 1, 12, 0, 0));
            Assert.AreEqual(20.00M, rate.Amount, "Standard Rate failed");
        }
        [TestMethod]
        public void Test559am330pm()
        {
            var rate = RateEngine.CalculateRate(new DateTime(2017, 2, 1, 5, 59, 0), new DateTime(2017, 2, 1, 15, 30, 0));
            Assert.AreEqual(20.00M, rate.Amount, "Standard Rate failed");
        }
        [TestMethod]
        public void Test6am329pm()
        {
            var rate = RateEngine.CalculateRate(new DateTime(2017, 2, 1, 6, 0, 0), new DateTime(2017, 2, 1, 15, 29, 0));
            Assert.AreEqual(20.00M, rate.Amount, "Standard Rate failed");
        }
        [TestMethod]
        public void Test6am330pm()
        {
            var rate = RateEngine.CalculateRate(new DateTime(2017, 2, 1, 6, 0, 0), new DateTime(2017, 2, 1, 15, 30, 0));
            Assert.AreEqual(13.00M, rate.Amount, "Early Bird Rate failed");
        }
        [TestMethod]
        public void Test6am4pm()
        {
            var rate = RateEngine.CalculateRate(new DateTime(2017, 2, 1, 6, 0, 0), new DateTime(2017, 2, 1, 16, 0, 0));
            Assert.AreEqual(13.00M, rate.Amount, "Early Bird Rate failed");
        }
        [TestMethod]
        public void Test6am1130pm()
        {
            var rate = RateEngine.CalculateRate(new DateTime(2017, 2, 1, 6, 0, 0), new DateTime(2017, 2, 1, 23, 30, 0));
            Assert.AreEqual(13.00M, rate.Amount, "Early Bird Rate failed");
        }
        [TestMethod]
        public void Test6am1131pm()
        {
            var rate = RateEngine.CalculateRate(new DateTime(2017, 2, 1, 6, 0, 0), new DateTime(2017, 2, 1, 23, 31, 0));
            Assert.AreEqual(20.00M, rate.Amount, "Standard Rate failed");
        }

        [TestMethod]
        public void Test9am1130pm()
        {
            var rate = RateEngine.CalculateRate(new DateTime(2017, 2, 1, 9, 0, 0), new DateTime(2017, 2, 1, 23, 30, 0));
            Assert.AreEqual(13.00M, rate.Amount, "Early Bird Rate failed");
        }
        [TestMethod]
        public void Test901am1130pm()
        {
            var rate = RateEngine.CalculateRate(new DateTime(2017, 2, 1, 9, 1, 0), new DateTime(2017, 2, 1, 23, 30, 0));
            Assert.AreEqual(20, rate.Amount, "Standard Rate failed");
        }



        [TestMethod]
        public void Test6pm1130pm()
        {
            var rate = RateEngine.CalculateRate(new DateTime(2017, 2, 1, 18, 0, 0), new DateTime(2017, 2, 1, 23, 30, 0));
            Assert.AreEqual(6.50M, rate.Amount, "Night Rate failed");
        }
        [TestMethod]
        public void Test6pm559am()
        {
            var rate = RateEngine.CalculateRate(new DateTime(2017, 2, 1, 18, 0, 0), new DateTime(2017, 2, 2, 5, 59, 0));
            Assert.AreEqual(6.50M, rate.Amount, "Night Rate failed");
        }


        [TestMethod]
        public void Sat1amSun3pm()
        {
            var rate = RateEngine.CalculateRate(new DateTime(2017, 2, 4, 1, 0, 0), new DateTime(2017, 2, 5, 15, 0, 0));
            Assert.AreEqual(10.00M, rate.Amount, "Weekend Rate failed");
        }
        [TestMethod]
        public void Sat1amMon3am()
        {
            var rate = RateEngine.CalculateRate(new DateTime(2017, 2, 4, 1, 0, 0), new DateTime(2017, 2, 6, 3, 0, 0));
            Assert.AreEqual(60.00M, rate.Amount, "Standard Rate failed");
        }
    }
}
