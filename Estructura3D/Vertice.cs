using OpenTK;
using System;

namespace ProyectoOpenTk.Estructura3D
{
    public class Vertice
    {
        public float X;
        public float Y;
        public float Z;

        public Vertice() {}

        public Vertice(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vertice(Vertice v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        private Vector4 ToVector4()
        {
            return new Vector4(X, Y, Z, 1);
        }

        public void setValues(float x, float y, float z)
        {
            X = x; Y = y; Z = z;
        }

        private void setValues(Vector4 v)
        {
            X = v.X; Y = v.Y; Z = v.Z;
        }

        public void ApplyTransform(Matrix4 transform)
        {
            setValues(Vector4.Transform(ToVector4(), transform));
        }

        public override string ToString()
        {
            return "("+X+", "+Y+", "+Z+")";
        }
    }
}
