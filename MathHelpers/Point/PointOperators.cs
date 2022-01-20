using System;

namespace MathHelpers
{
    public static class PointOperators
    {
        public static double DistanceTo(this Point2d p, Point2d p2) => Math.Sqrt(Math.Pow(p.X - p2.X, 2) + Math.Pow(p.Y - p2.Y, 2));
    }
    
    public partial class Point2d
    {
        
    }
}