using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk
{
    public class Objeto
    {
        public Vertice centro = new Vertice(0, 0, 0);
        public Dictionary<string, Parte> partes = new Dictionary<string, Parte>();

        public Objeto() {}

        public Objeto(float x, float y, float z)
        {
            centro = new Vertice(x, y, z);
        }

        public void AddParte(string name, Parte p)
        {
            p.centro.X += centro.X;
            p.centro.Y += centro.Y;
            p.centro.Z += centro.Z;
            partes.Add(name, p);
        }

        public void Draw()
        {
            foreach (Parte p in partes.Values)
            {
                p.Draw();
            }
        }
    }
}
