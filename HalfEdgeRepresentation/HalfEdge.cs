using System;

namespace HalfEdgeRepresentation
{
    public class HalfEdge
    {
        private Face face;
        private HalfEdge head, tail;
        private Vertex vertHead;
        private HalfEdge opposite;
    }
}