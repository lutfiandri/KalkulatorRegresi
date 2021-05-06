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
    public class InputTests
    {
        [TestMethod()]
        public void MultilineToDoubleArrayTest1()
        {
            // Arrange
            double[] expected = new double[] { 1.2, 2.3, 23.4, -1.232 };
            double[] actual = Input.MultilineToDoubleArray("1,2\n2,3 \n  23,4 \n -1,232");
            
            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultilineToDoubleArrayTest2()
        {
            // Arrange
            double[] expected = new double[] { 1.2, 2.3, 23.4, -1.232 };
            double[] actual = Input.MultilineToDoubleArray("1.2   \n2.3 \n  23.4 \n -1.232");

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultilineToDoubleArrayTest3()
        {
            // Arrange
            double[] expected = new double[] { };
            double[] actual = Input.MultilineToDoubleArray("   ");

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}