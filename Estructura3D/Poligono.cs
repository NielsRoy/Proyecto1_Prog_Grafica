using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;

namespace ProyectoOpenTk.Estructura3D
{
    public class Poligono : IDrawable
    {
        public Color4 color = Color4.Gray;
        public List<Vertice> vertices = new List<Vertice>();

        public Poligono() {}

        public Poligono(Color4 color)
        {
            this.color = color;
        }

        public void AddVertice(float x, float y, float z)
        {
            vertices.Add(new Vertice(x, y, z));
        }

        public void Draw()
        {
            GL.Color4(Color4.Black);
            GL.Begin(BeginMode.LineLoop);
            foreach (Vertice v in vertices)
            {
                GL.Vertex3(v.X, v.Y, v.Z);
                //GL.Vertex4(v.ToVector4());
            }
            GL.End();

            GL.Color4(color);
            GL.Begin(BeginMode.Polygon);
            foreach (Vertice v in vertices)
            {
                GL.Vertex3(v.X, v.Y, v.Z);
            }
            GL.End();
        }

        public void ApplyTransform(Matrix4 transform)
        {
            foreach (Vertice v in vertices)
            {
                v.ApplyTransform(transform);
            }
        }
    }
}
