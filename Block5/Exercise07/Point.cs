using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    public class Point
    {
        private double coordinateX;
        private double coordinateY;

        public double CoordinateX
        {
            get { return coordinateX; }
            set { coordinateX = value; }
        }

        public double CoordinateY
        {
            get { return coordinateY; }
            set { coordinateY = value; }
        }

        public Point(double x, double y)
        {
            CoordinateX = x;
            CoordinateY = y;
        }
    }
}
