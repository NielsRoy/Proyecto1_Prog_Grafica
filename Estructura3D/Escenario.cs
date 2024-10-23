using OpenTK;
using System.Collections.Generic;

namespace ProyectoOpenTk.Estructura3D
{
    public class Escenario : Figura3D
    {
        public Dictionary<string, Objeto> objetos = new Dictionary<string, Objeto>();

        public Escenario(float x, float y, float z): base(x, y, z) {}

        public override void Draw()
        {
            foreach (Objeto obj in objetos.Values)
            {
                obj.Draw();
            }
        }

        public override void ApplyTransform(Matrix4 transform)
        {
            foreach (Objeto o in objetos.Values)
            {
                o.centro.ApplyTransform(transform);
                o.ApplyTransform(transform);
            }
        }

        public override List<Vertice> GetVertices()
        {
            List<Vertice> vertices = new List<Vertice>();
            foreach (Objeto objeto in objetos.Values)
            {
                vertices.AddRange(objeto.GetVertices());
            }
            return vertices;
        }
    }
}
