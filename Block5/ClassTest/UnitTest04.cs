using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise04;

namespace ClassTest
{
    [TestClass]
    public class UnitTest04
    {
        Complex[] numbers;

        [TestInitialize]
        public void ComplexNumberInitialize()
        {
            numbers = new Complex[]
            {
                new Complex(5,3),
                new Complex(-6,4),
                new Complex(2, 1),
                new Complex(1, -7),
            };
        }

        [TestMethod]
        public void TestComplexSum()
        {
            Complex sum = numbers[0] + numbers[1];

            Assert.AreEqual(-1, sum.RealPart);
            Assert.AreEqual(7, sum.ImaginaryPart);
        }

        [TestMethod]
        public void TestComplexDifference()
        {
            Complex diff = numbers[2] - numbers[3];

            Assert.AreEqual(1, diff.RealPart);
            Assert.AreEqual(8, diff.ImaginaryPart);
        }
        
        [TestMethod]
        public void TestComplexMult()
        {
            Complex mul = numbers[1] * numbers[3];

            Assert.AreEqual(22, mul.RealPart);
            Assert.AreEqual(46, mul.ImaginaryPart);
        }

        [TestMethod]
        public void TestComplexDivision()
        {
            Complex div = numbers[0] / numbers[2];

            Assert.AreEqual(1.4, div.RealPart);
            Assert.AreEqual(2.2, div.ImaginaryPart);
        }

        [TestMethod]
        public void TestComplexConiugate()
        {
            Assert.AreEqual(5,(~numbers[0]).RealPart);
            Assert.AreEqual(-3,(~numbers[0]).ImaginaryPart);

            Assert.AreEqual(1, (~numbers[3]).RealPart);
            Assert.AreEqual(7, (~numbers[3]).ImaginaryPart);
        }
    }
}
