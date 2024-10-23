using OpenTK;
using System.Collections.Generic;

namespace ProyectoOpenTk.Estructura3D
{
    public class Parte : Figura3D 
    {
        public List<Poligono> poligonos = new List<Poligono>();

        public Parte(float x, float y, float z) : base(x, y, z) {}

        public override void Draw()
        {
            foreach (Poligono p in poligonos)
            {
                p.Draw();
            }
        }

        public override void ApplyTransform(Matrix4 transform)
        {
            foreach (Poligono pol in poligonos)
            {
                pol.ApplyTransform(transform);
            }
        }

        public override List<Vertice> GetVertices()
        {
            List<Vertice> vertices = new List<Vertice>();
            foreach (Poligono p in poligonos)
            {
                vertices.AddRange(p.vertices);
            }
            return vertices;
        }
    }
}
