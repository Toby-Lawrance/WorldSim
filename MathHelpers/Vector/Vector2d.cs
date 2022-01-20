using System;
using System.Numerics;

namespace MathHelpers
{
    public partial class Vector2d
    {
        public double X, Y;

        public Vector2d()
        {
            X = 0;
            Y = 0;
        }

        public Vector2d(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}