using System;

namespace MathHelpers
{
    public class BoundingBox
    {
        public Point2d TopLeft => new(bottomLeft.X, topRight.Y);
        public Point2d TopRight => new(topRight.X, topRight.Y);
        public Point2d BottomLeft => new(bottomLeft.X, bottomLeft.Y);
        public Point2d BottomRight => new(topRight.X, bottomLeft.Y);

        private Point2d bottomLeft, topRight;

        public BoundingBox(Point2d corner1, Point2d corner2)
        {
            bottomLeft = new Point2d(Math.Min(corner1.X, corner2.X), Math.Min(corner1.Y, corner2.Y));
            topRight = new Point2d(Math.Max(corner1.X, corner2.X), Math.Max(corner1.Y, corner2.Y));
        }
    }
}