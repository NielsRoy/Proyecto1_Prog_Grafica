using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk
{
    public class Parte
    {
        public Vertice centro;
        public List<Poligono> poligonos;

        public Parte()
        {
            centro = new Vertice(0, 0, 0);
        }

        public Parte(float x, float y, float z)
        {
            centro = new Vertice(x, y, z);
            poligonos = new List<Poligono>();
        }

        public void AddPoligono(Poligono p)
        {
            foreach (Vertice v in p.vertices)
            {
                v.X += centro.X;
                v.Y += centro.Y;
                v.Z += centro.Z;
            }
            poligonos.Add(p);
        }

        public void Draw()
        {
            foreach (Poligono p in poligonos)
            {
                p.Draw();
            }
        }
    }
}
