using OpenTK;
using System;
using System.Collections.Generic;

namespace ProyectoOpenTk.Estructura3D
{
    public abstract class Figura3D : IDrawable
    {
        public Vertice centro = new Vertice(0, 0, 0);   //Talvez renombrar a pivote

        public Figura3D() {}

        public Figura3D(float x, float y, float z)
        {
            centro = new Vertice(x, y, z);
        }

        public abstract void Draw();

        public void Translate(float x, float y, float z)
        {
            Matrix4 translation = Matrix4.CreateTranslation(x, y, z);
            //Solo la traslacion afecta al centro de una figura 3d ya que la rotacion y escalacion
            //usan de pivote al centro de la figura 3d
            centro.ApplyTransform(translation);
            ApplyTransform(translation);
        }

        private Matrix4 getTransformMatrix(Matrix4 transform)
        {
            Matrix4 toUniverseOrigin = Matrix4.CreateTranslation(-centro.X, -centro.Y, -centro.Z);
            Matrix4 result = Matrix4.Mult(toUniverseOrigin, transform);
            Matrix4 toOriginal = Matrix4.CreateTranslation(centro.X, centro.Y, centro.Z);
            return Matrix4.Mult(result, toOriginal);
        }

        public void Scale(float x, float y, float z)
        {
            Matrix4 scalation = Matrix4.CreateScale(x, y, z);
            scalation = getTransformMatrix(scalation);
            ApplyTransform(scalation);
        }

        public void Rotate(float angle, float x, float y, float z)
        {
            angle = MathHelper.DegreesToRadians(angle);
            Matrix4 rotation = Matrix4.CreateRotationX(angle * x);
            rotation = Matrix4.Mult(rotation, Matrix4.CreateRotationY(angle* y));
            rotation = Matrix4.Mult(rotation, Matrix4.CreateRotationZ(angle * z));
            rotation = getTransformMatrix(rotation);
            ApplyTransform(rotation);
        }

        public abstract void ApplyTransform(Matrix4 transform);

        private Vertice GetGeomtryCenter(List<Vertice> vertices)
        {
            if (vertices == null || vertices.Count == 0)
                throw new ArgumentException("La lista de vértices no puede estar vacía.");

            // Encuentra los límites del cuboide
            // Inicializa los valores min y max con los del primer vértice
            float minX = vertices[0].X;
            float minY = vertices[0].Y;
            float minZ = vertices[0].Z;

            float maxX = vertices[0].X;
            float maxY = vertices[0].Y;
            float maxZ = vertices[0].Z;

            // Recorre la lista de vértices para encontrar los valores min y max
            foreach (var vertex in vertices)
            {
                if (vertex.X < minX) minX = vertex.X;
                if (vertex.Y < minY) minY = vertex.Y;
                if (vertex.Z < minZ) minZ = vertex.Z;

                if (vertex.X > maxX) maxX = vertex.X;
                if (vertex.Y > maxY) maxY = vertex.Y;
                if (vertex.Z > maxZ) maxZ = vertex.Z;
            }

            // Vértices opuestos del cuboide
            Vertice vertex1 = new Vertice(minX, minY, minZ);
            Vertice vertex2 = new Vertice(maxX, maxY, maxZ);

            // Calcula el centro del cuboide
            float centerX = (minX + maxX) / 2;
            float centerY = (minY + maxY) / 2;
            float centerZ = (minZ + maxZ) / 2;

            // Retorna el centro del cuboide
            return new Vertice(centerX, centerY, centerZ);
        }

        public void SetCenterToGeometry()
        {
            List<Vertice> vertices = GetVertices();
            centro = GetGeomtryCenter(vertices);
        }

        public abstract List<Vertice> GetVertices();
    }
}
