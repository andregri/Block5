using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
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

        [TestMethod]
        public void TestNestedLoop()
        {
            IEnumerator outerInterval = new Interval(1, 3).GetEnumerator();
            IEnumerator innerInterval = new Interval(6, 8).GetEnumerator();

            int[] result = new int[9];
            int[] expected = {7, 8, 9, 8, 9, 10, 9, 10, 11 };

            int counter = 0;
            while (outerInterval.MoveNext())
            {
                while (innerInterval.MoveNext())
                {
                    result[counter] = (int)innerInterval.Current + (int)outerInterval.Current;
                    counter++;
                }
                innerInterval.Reset();
            }

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
