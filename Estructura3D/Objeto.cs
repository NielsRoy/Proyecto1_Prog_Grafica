using OpenTK;
using System.Collections.Generic;

namespace ProyectoOpenTk.Estructura3D
{
    public class Objeto : Figura3D
    {
        public Dictionary<string, Parte> partes = new Dictionary<string, Parte>();

        public Objeto(float x, float y, float z) : base(x, y, z) {}

        public override void Draw()
        {
            foreach (Parte p in partes.Values)
            {
                p.Draw();
            }
        }

        public override void ApplyTransform(Matrix4 transform)
        {
            foreach (Parte p in partes.Values)
            {
                p.centro.ApplyTransform(transform);
                p.ApplyTransform(transform);
            }
        }

        public override List<Vertice> GetVertices()
        {
            List<Vertice> vertices = new List<Vertice>();
            foreach (Parte p in partes.Values)
            {
                vertices.AddRange(p.GetVertices());
            }
            return vertices;
        }
    }
}
