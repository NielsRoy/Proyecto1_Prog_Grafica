using OpenTK;
using OpenTK.Graphics.OpenGL;
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

        public void Translate(float x, float y, float z)
        {
            Transform(Matrix4.CreateTranslation(x, y, z));
        }

        public void Scale(float x, float y, float z)
        {
            Transform(Matrix4.CreateScale(x, y, z));
        }

        public void Rotate(float angle, float x, float y, float z)
        {
            angle = MathHelper.DegreesToRadians(angle);
            Matrix4 m = Matrix4.CreateRotationX(angle * x);
            m = Matrix4.Mult(m, Matrix4.CreateRotationY(angle * y));
            m = Matrix4.Mult(m, Matrix4.CreateRotationZ(angle * z));
            Transform(m);
        }

        private void Transform(Matrix4 m)
        {
            foreach (Objeto o in objetos.Values)
            {
                foreach (Parte p in o.partes.Values)
                {
                    foreach (Poligono pol in p.poligonos)
                    {
                        foreach (Vertice v in pol.vertices)
                        {
                            v.setValues(Vector4.Transform(v.ToVector4(), m));
                        }
                    }
                }
            }
        }
    }
}
