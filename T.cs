using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk
{
    public class T
    {
        public static Objeto getObjeto()
        {
            Objeto obj = new Objeto(5, 8, -1);

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
    }
}
