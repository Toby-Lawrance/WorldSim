using System;

namespace MathHelpers
{
    public partial class Point2d
    {
        public double X, Y;
        
        public Point2d()
        {
            X = 0;
            Y = 0;
        }

        public Point2d(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}