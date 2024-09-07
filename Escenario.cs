using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk
{
    public class Escenario
    {
        public Vertice centro = new Vertice(0, 0, 0);
        public Dictionary<string, Objeto> objetos = new Dictionary<string, Objeto>();

        public Escenario() {}

        public Escenario(float x, float y, float z)
        {
            centro = new Vertice(x, y, z);
        }

        public void AddObjeto(string name, Objeto obj)
        {
            obj.centro.X += centro.X;
            obj.centro.Y += centro.Y;
            obj.centro.Z += centro.Z;
            objetos.Add(name, obj);
        }

        public void Draw()
        {
            foreach (Objeto obj in objetos.Values)
            {
                obj.Draw();
            }
        }
    }
}
