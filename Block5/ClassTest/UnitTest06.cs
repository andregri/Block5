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

        [TestMethod]
        public void TestSum()
        {
            Interval i = new Interval(1, 5);
            int a = 5;

            int[] exp1 = { 6, 7, 8, 9, 10 };
            CollectionAssert.AreEqual(exp1, (int[])(i + a));
            CollectionAssert.AreEqual(exp1, (int[])(a + i));
        }

        [TestMethod]
        public void TestDifference()
        {
            Interval i = new Interval(1, 5);
            int a = 5;

            int[] exp = { -4, -3, -2, -1, 0 };
            CollectionAssert.AreEqual(exp, (int[])(i - a));
        }

        [TestMethod]
        public void TestShift()
        {
            Interval i = new Interval(1, 5);
            int sh = 3;

            int[] shiftRight = {1, 2, 3, 4, 5, 6, 7, 8 };
            CollectionAssert.AreEqual(shiftRight, (int[])(i >> sh));

            int[] shiftLeft = { 4, 5 };
            CollectionAssert.AreEqual(shiftLeft, (int[])(i << sh));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Interval i = new Interval(1, 3);
            int a = 2;

            int[] exp = { 2, 3, 4, 5, 6 };
            CollectionAssert.AreEqual(exp, (int[])(i * a));
            CollectionAssert.AreEqual(exp, (int[])(a * i));
        } 
    }
}
