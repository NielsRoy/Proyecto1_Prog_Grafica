using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk
{
    public class T
    {
        public Vertice centro;

        public T(float x, float y, float z)
        {
            centro = new Vertice(x, y, z);
        }

        public void Draw()
        {
            GL.Color4(Color4.Blue);
            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-3f + centro.X, 0f + centro.Y, -3f + centro.Z);
            GL.Vertex3(3f + centro.X, 0f + centro.Y, -3f + centro.Z);
            GL.Vertex3(3f + centro.X, 0f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 0f + centro.Y, 3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.Vertex3(9f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-9f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(3f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.Vertex3(3f + centro.X, 0f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 0f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(3f + centro.X, 0f + centro.Y, -3f + centro.Z);
            GL.Vertex3(3f + centro.X, 0f + centro.Y, 3f + centro.Z);
            GL.Vertex3(3f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.Vertex3(3f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-3f + centro.X, 0f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 0f + centro.Y, -3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.Vertex3(-9f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(3f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.Vertex3(3f + centro.X, 0f + centro.Y, -3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 0f + centro.Y, -3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(-9f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.Vertex3(-9f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.End();

            //----

            GL.Color4(Color4.Black);
            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-3f + centro.X, 0f + centro.Y, -3f + centro.Z);
            GL.Vertex3(3f + centro.X, 0f + centro.Y, -3f + centro.Z);
            GL.Vertex3(3f + centro.X, 0f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 0f + centro.Y, 3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.Vertex3(9f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.Vertex3(3f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.Vertex3(3f + centro.X, 0f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 0f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-9f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(3f + centro.X, 0f + centro.Y, -3f + centro.Z);
            GL.Vertex3(3f + centro.X, 0f + centro.Y, 3f + centro.Z);
            GL.Vertex3(3f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.Vertex3(3f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-3f + centro.X, 0f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 0f + centro.Y, -3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.Vertex3(3f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.Vertex3(3f + centro.X, 0f + centro.Y, -3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 0f + centro.Y, -3f + centro.Z);
            GL.Vertex3(-3f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.Vertex3(-9f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.Vertex3(9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.Vertex3(9f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, 3f + centro.Z);
            GL.Vertex3(-9f + centro.X, 24f + centro.Y, -3f + centro.Z);
            GL.Vertex3(-9f + centro.X, 18f + centro.Y, -3f + centro.Z);
            GL.Vertex3(-9f + centro.X, 18f + centro.Y, 3f + centro.Z);
            GL.End();
        }
    }
}
