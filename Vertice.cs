
using OpenTK;

namespace ProyectoOpenTk
{
    public class Vertice
    {
        public float X;
        public float Y;
        public float Z;

        public Vertice(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector4 ToVector4()
        {
            return new Vector4(X, Y, Z, 1);
        }

        public void setValues(Vector4 v)
        {
            X = v.X; Y = v.Y; Z = v.Z;
        }

        public override string ToString()
        {
            return "("+X+", "+Y+", "+Z+")";
        }
    }
}
