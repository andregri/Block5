using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise07;

namespace ClassTest
{
    [TestClass]
    public class UnitTest07
    {
        public static bool veryCloseToZero(Point p)
        {
            return (Math.Abs(p.CoordinateX + p.CoordinateY) <= 0.000001 ? true : false);
        }

        // declare array of Point
        Point[] points;

        [TestInitialize]
        public void InitializeArrayOfPoint()
        {
            points = new Point[]
            {
                new Point(3,-3),
                new Point(3,2),
                new Point(5,7),
                new Point(6,4),
                new Point(-3,-5),
            };
        }

        [TestMethod]
        public void TestAnonymousDelegateUsingLambdaFunction()
        {
            Point searchedPoint = Array.Find(points,
                p => Math.Abs(p.CoordinateX + p.CoordinateY) <= 0.000001);

            Assert.AreEqual(3, searchedPoint.CoordinateX, 0.000001);
            Assert.AreEqual(-3, searchedPoint.CoordinateY, 0.000001);
        }

        [TestMethod]
        public void TestAnonymousDelegate()
        {
            Point searchedPoint = Array.Find(points, delegate (Point p)
             {
                 return Math.Abs(p.CoordinateX + p.CoordinateY) <= 0.000001;
             });

            Assert.AreEqual(3, searchedPoint.CoordinateX, 0.000001);
            Assert.AreEqual(-3, searchedPoint.CoordinateY, 0.000001);
        }

        [TestMethod]
        public void TestNamedStaticMethod()
        {
            Point searchedPoint = Array.Find(points, veryCloseToZero);

            Assert.AreEqual(3, searchedPoint.CoordinateX, 0.000001);
            Assert.AreEqual(-3, searchedPoint.CoordinateY, 0.000001);
        }

        [TestMethod]
        public void SortListOfPointsUsingDelegate()
        {
            // sort element (points are sorted by the absolute value of sum of their components )
            Array.Sort(points, delegate (Point p1, Point p2)
            {
                if (Math.Abs(p1.CoordinateX + p1.CoordinateY) >= Math.Abs(p2.CoordinateX + p2.CoordinateY))
                    return 1;
                else
                    return -1;
            });

            // new first point in the array
            Assert.AreEqual(3, points[0].CoordinateX);
            Assert.AreEqual(-3, points[0].CoordinateY);

            // new last point in the array
            Assert.AreEqual(5, points[4].CoordinateX);
            Assert.AreEqual(7, points[4].CoordinateY);
        }
    }
}

