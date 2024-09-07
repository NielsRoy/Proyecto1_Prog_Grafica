using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk
{
    public class Poligono
    {
        public Color4 color;

        public List<Vertice> vertices;

        //private Matrix4 transformations;
        //private Matrix4 iTransformations;

        public Poligono()
        {
            vertices = new List<Vertice>();
            color = Color4.Gray;
            //transformations = Matrix4.Identity;
            //iTransformations = Matrix4.Identity;
        }

        public Poligono(Color4 color)
        {
            vertices = new List<Vertice>();
            this.color = color;
            //transformations = Matrix4.Identity;
            //iTransformations = Matrix4.Identity;
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
            }
            GL.End();

            GL.Color4(color);
            GL.Begin(BeginMode.Polygon);
            foreach (Vertice v in vertices)
            {
                GL.Vertex3(v.X, v.Y, v.Z);
            }
            GL.End();

            //iTransformations = Matrix4.Identity;
            //transformations = Matrix4.Identity;
        }
    }
}
