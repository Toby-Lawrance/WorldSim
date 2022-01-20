using System.Collections.Generic;

namespace TriangleRepresentation
{
    public class Triangle
    {
        private Triangle t1, t2, t3;
        public IEnumerable<Triangle> AdjacentFaces => new[] { t1, t2, t3 };
        private Vertex v1, v2, v3;
        public IEnumerable<Vertex> Vertices => new[] { v1, v2, v3 };
    }
}