using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassTestDel.Tests
{
    [TestClass]
    public class TriangleAreaTest
    {
        [TestMethod]
        public void Area_3_4_5()
        {
            double a = 3, b = 4, c = 5;
            double expected = 6;

            double actual = TriangleArea.Area(a, b, c);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Area_m1_4_5()
        {
            double a = -1, b = 4, c = 5;
            double expected = 6;

            double actual = TriangleArea.Area(a, b, c);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Area_2_4_5()
        {
            double a = 2, b = 4, c = 5;
            double expected = 6;

            double actual = TriangleArea.Area(a, b, c);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Area_3_3_3()
        {
            double a = 3, b = 3, c = 3;
            double expected = 6;

            double actual = TriangleArea.Area(a, b, c);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Area_2_4_8()
        {
            double a = 2, b = 4, c = 8;
            double expected = 4;

            double actual = TriangleArea.Area(a, b, c);

            Assert.AreEqual(expected, actual);
        }
    }
}
