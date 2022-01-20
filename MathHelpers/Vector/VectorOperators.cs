namespace MathHelpers
{
    public static class VectorOperators
    {
        public static Vector2d Add(this Vector2d v, Vector2d v2) => new Vector2d(v.X + v2.X, v.Y + v2.Y);

        public static Vector2d Subtract(this Vector2d v, Vector2d v2) => new Vector2d(v.X - v2.X, v.Y - v2.Y);

        public static Vector2d Negate(this Vector2d v) => new Vector2d(-v.X, -v.Y);
    }

    public partial class Vector2d
    {
        public static Vector2d operator +(Vector2d v, Vector2d v2) => v.Add(v2);

        public static Vector2d operator -(Vector2d v, Vector2d v2) => v.Subtract(v2);

        public static Vector2d operator -(Vector2d v)
        {
            return v.Negate();
        }
    }
}