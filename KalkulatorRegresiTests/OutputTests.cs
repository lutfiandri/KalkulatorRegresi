using Microsoft.VisualStudio.TestTools.UnitTesting;
using KalkulatorRegresi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorRegresi.Tests
{
    [TestClass()]
    public class OutputTests
    {
        [TestMethod()]
        public void DoubleArrayToStringTest()
        {
            // Arrange
            string expected = "1 2 3 4 ";

            double[] nums = new double[] { 1, 2, 3, 4 };
            string actual = Output.DoubleArrayToString(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
