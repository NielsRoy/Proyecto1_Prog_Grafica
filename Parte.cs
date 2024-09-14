using OpenTK;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk
{
    public class Parte
    {
        public Vertice centro = new Vertice(0, 0, 0);
        public List<Poligono> poligonos = new List<Poligono>();

        public Parte() {}

        public Parte(float x, float y, float z)
        {
            centro = new Vertice(x, y, z);
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
            foreach (Poligono pol in poligonos)
            {
                foreach (Vertice v in pol.vertices)
                {
                    v.setValues(Vector4.Transform(v.ToVector4(), m));
                }
            }
            
        }
    }
}
