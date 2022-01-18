using System;

namespace MathHelpers
{
    public class BoundingBox
    {
        public Vector2d TopLeft => new(bottomLeft.X, topRight.Y);
        public Vector2d TopRight => new(topRight.X, topRight.Y);
        public Vector2d BottomLeft => new(bottomLeft.X, bottomLeft.Y);
        public Vector2d BottomRight => new(topRight.X, bottomLeft.Y);

        private Vector2d bottomLeft, topRight;

        public BoundingBox(Vector2d corner1, Vector2d corner2)
        {
            bottomLeft = new Vector2d(Math.Min(corner1.X, corner2.X), Math.Min(corner1.Y, corner2.Y));
            topRight = new Vector2d(Math.Max(corner1.X, corner2.X), Math.Max(corner1.Y, corner2.Y));
        }
    }
}