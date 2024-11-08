using ProyectoOpenTk.Estructura3D;
using System;

namespace ProyectoOpenTk.EstructuraAnimacion
{
    //public enum Transformacion
    //{
    //    TRASLADAR,
    //    ESCALAR,
    //    ROTAR
    //}
    
    public class Accion
    {
        //public Transformacion tipo;
        //public double valor;
        //public double x;
        //public double y;
        //public double z;
        public Transformacion transformacion;
        public Figura3D elemento; 
        public float objetivo;  //30grados, mover 30 en x, escalar +30 en y 
        public double tiempoInicio; //Con respecto al tiempo global, la duracion del libreto
        public double duracion;

        public bool iniciado = false;
        public float objetivoRestante;
        public double tiempoRestante;

        public Accion(Transformacion transformacion, Figura3D elemento, float objetivo, double tiempoInicio, double duracion)
        {
            this.transformacion = transformacion;
            this.elemento = elemento;
            this.objetivo = objetivo;
            this.tiempoInicio = tiempoInicio;
            this.duracion = duracion;
            objetivoRestante = objetivo;
            tiempoRestante = duracion;
        }

        public void Apply(float step)
        {
            iniciado = true;
            objetivo -= step;
            transformacion.Apply(elemento, step);
        }

        public void Run(float fps)
        {
            //calcular una vez y no todo el tiempo o sino calcular cada 1 seg por ejemplo
            float step = (float)(objetivoRestante / (fps * tiempoRestante));
            objetivoRestante -= step;
            transformacion.Apply(elemento, step);
        }
    }
}
