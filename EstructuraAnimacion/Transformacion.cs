using ProyectoOpenTk.Estructura3D;

namespace ProyectoOpenTk.EstructuraAnimacion
{
    public enum Tipo
    {
        TRASLADAR,
        ESCALAR,
        ROTAR
    }

    public class Transformacion
    {
        public static readonly string TRASLADAR = "TRASLADAR";
        public static readonly string ESCALAR = "ESCALAR";
        public static readonly string ROTAR = "ROTAR";

        public readonly string tipo;
        public readonly float x;
        public readonly float y;
        public readonly float z;

        public Transformacion(string tipo, float x, float y, float z)
        { 
            this.tipo = tipo;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Apply(Figura3D elemento, float valor)
        {
            if (tipo == TRASLADAR)
                elemento.Translate(x * valor, y * valor, z * valor);

            if (tipo == ESCALAR)
                elemento.Scale(x * valor, y * valor, z * valor);

            if (tipo == ROTAR)
                elemento.Rotate(valor, x, y, z);
        }
    }
}
