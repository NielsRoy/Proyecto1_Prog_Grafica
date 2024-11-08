using OpenTK;

namespace ProyectoOpenTk.Estructura3D
{
    public interface IDrawable
    {
        void Draw();

        void ApplyTransform(Matrix4 transform);
    }
}
