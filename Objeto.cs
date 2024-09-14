using OpenTK;
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

            Matrix4 toOrigin = Matrix4.CreateTranslation(-centro.X, -centro.Y, -centro.Z);
            Matrix4 r = Matrix4.CreateRotationX(angle * x);
            r = Matrix4.Mult(r, Matrix4.CreateRotationY(angle * y));
            r = Matrix4.Mult(r, Matrix4.CreateRotationZ(angle * z));
            Matrix4 toOriginal = Matrix4.CreateTranslation(centro.X, centro.Y, centro.Z);

            Matrix4 t = Matrix4.Mult(toOrigin, r);
            t = Matrix4.Mult(t, toOriginal);

            Transform(t);
        }

        private void Transform(Matrix4 m)
        {
            foreach (Parte p in partes.Values)
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
