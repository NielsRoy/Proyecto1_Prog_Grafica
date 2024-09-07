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

        public static Objeto getObjeto()
        {
            Objeto obj = new Objeto(2, 1, -1);

            Parte superior = new Parte(0, 0, 0);

            Poligono p1 = new Poligono(Color4.Green);
            p1.AddVertice(-9, 24, 3);
            p1.AddVertice(-9, 24, -3);
            p1.AddVertice(-9, 18, -3);
            p1.AddVertice(-9, 18, 3);
            superior.AddPoligono(p1);

            Poligono p2 = new Poligono(Color4.Green);
            p2.AddVertice(-9, 24, 3);
            p2.AddVertice(9, 24, 3);
            p2.AddVertice(9, 18, 3);
            p2.AddVertice(-9, 18, 3);
            superior.AddPoligono(p2);

            Poligono p3 = new Poligono(Color4.Green);
            p3.AddVertice(-9, 18, 3);
            p3.AddVertice(-9, 18, -3);
            p3.AddVertice(9, 18, -3);
            p3.AddVertice(9, 18, 3);
            superior.AddPoligono(p3);

            Poligono p4 = new Poligono(Color4.Green);
            p4.AddVertice(-9, 18, -3);
            p4.AddVertice(-9, 24, -3);
            p4.AddVertice(9, 24, -3);
            p4.AddVertice(9, 18, -3);
            superior.AddPoligono(p4);

            Poligono p5 = new Poligono(Color4.Green);
            p5.AddVertice(-9, 24, 3);
            p5.AddVertice(-9, 24, -3);
            p5.AddVertice(9, 24, -3);
            p5.AddVertice(9, 24, 3);
            superior.AddPoligono(p5);

            Poligono p6 = new Poligono(Color4.Green);
            p6.AddVertice(9, 24, 3);
            p6.AddVertice(9, 24, -3);
            p6.AddVertice(9, 18, -3);
            p6.AddVertice(9, 18, 3);
            superior.AddPoligono(p6);

            obj.AddParte("cabeza", superior);


            Parte inferior = new Parte(0, 0, 0);

            Poligono p7 = new Poligono(Color4.Yellow);
            p7.AddVertice(-3, 18, 3);
            p7.AddVertice(3, 18, 3);
            p7.AddVertice(3, 0, 3);
            p7.AddVertice(-3, 0, 3);
            inferior.AddPoligono(p7);

            Poligono p8 = new Poligono(Color4.Yellow);
            p8.AddVertice(-3, 18, -3);
            p8.AddVertice(3, 18, -3);
            p8.AddVertice(3, 0, -3);
            p8.AddVertice(-3, 0, -3);
            inferior.AddPoligono(p8);

            Poligono p9 = new Poligono(Color4.Yellow);
            p9.AddVertice(-3, 18, 3);
            p9.AddVertice(-3, 18, -3);
            p9.AddVertice(-3, 0, -3);
            p9.AddVertice(-3, 0, 3);
            inferior.AddPoligono(p9);

            Poligono p10 = new Poligono(Color4.Yellow);
            p10.AddVertice(3, 18, 3);
            p10.AddVertice(3, 18, -3);
            p10.AddVertice(3, 0, -3);
            p10.AddVertice(3, 0, 3);
            inferior.AddPoligono(p10);

            Poligono p11 = new Poligono(Color4.Yellow);
            p11.AddVertice(-3, 18, 3);
            p11.AddVertice(-3, 18, -3);
            p11.AddVertice(3, 18, -3);
            p11.AddVertice(3, 18, 3);
            inferior.AddPoligono(p11);

            Poligono p12 = new Poligono(Color4.Yellow);
            p12.AddVertice(-3, 0, 3);
            p12.AddVertice(-3, 0, -3);
            p12.AddVertice(3, 0, -3);
            p12.AddVertice(3, 0, 3);
            inferior.AddPoligono(p12);

            obj.AddParte("cuerpo", inferior);

            return obj;
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
