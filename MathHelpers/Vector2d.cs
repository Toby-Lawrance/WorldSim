using System;
using System.Numerics;

namespace MathHelpers
{
    public class Vector2d
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

        public double DistanceTo(Vector2d other) =>
            Math.Sqrt(Math.Pow(this.X - other.X, 2) + Math.Pow(this.Y - other.Y, 2));
    }
}