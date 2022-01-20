using System.Collections.Generic;

namespace TriangleRepresentation
{
    public class Mesh
    {
        private List<Triangle> faces = new();
        private List<Vertex> vertices = new();
        public IReadOnlyList<Triangle> Faces => faces.AsReadOnly();
        public IReadOnlyList<Vertex> Vertices => vertices.AsReadOnly();

        public void AddFace(Triangle added)
        {
            if (added is null)
            {
                return;
            }
            faces.Add(added);
        }

        public void AddVertex(Vertex added)
        {
            if (added is null)
            {
                return;
            }
            vertices.Add(added);
        }
    }
}