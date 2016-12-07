using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise06;

namespace ClassTest
{
    [TestClass]
    public class UnitTest06
    {
        [TestMethod]
        public void TestToArray()
        {
            Interval i = new Interval(10, 15);
            int[] actual = (int[])i;
            int[] expected = { 10, 11, 12, 13, 14, 15 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
