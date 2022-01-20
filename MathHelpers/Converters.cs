using System.Collections.Generic;
using System.Linq;

namespace MathHelpers
{
    public static class Converters
    {
        #region VectorConverters
        public static Point2d ToPoint2d(this Vector2d v)
        {
            return new Point2d(v.X, v.Y);
        }

        public static Point2d ToPoint2d(this Vector2d v, Point2d from)
        {
            return new Point2d(from.X + v.X, from.Y + v.Y);
        }

        public static Point2d ToPoint2d(this IEnumerable<Vector2d> vectors)
        {
            return vectors.Aggregate((vector, vector2) => vector + vector2).ToPoint2d();
        }
        
        public static Point2d ToPoint2d(this IEnumerable<Vector2d> vectors, Point2d from)
        {
            return vectors.Prepend(from.ToVector2d()).Aggregate((vector, vector2) => vector + vector2).ToPoint2d();
        }
        #endregion

        #region PointConverters
        public static Vector2d ToVector2d(this Point2d p)
        {
            return new Vector2d(p.X, p.Y);
        }
        #endregion
        
    }
}