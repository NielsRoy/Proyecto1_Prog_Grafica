using OpenTK;
using ProyectoOpenTk.Estructura3D;
using System;
using System.Collections.Generic;
using System.Text;

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
        //public float valor;
        //public float x;
        //public float y;
        //public float z;
        public Transformacion transformacion;
        public Figura3D elemento;   //En lugar de figura 3d que reciba escenario y nombre ?
        public float objetivo;  //30grados, mover 30 en x, escalar +30 en y 
        public float tiempoInicio;
        public float duracion;
        //agregar centro o pivote que usara para la transformacion ?
        //public Vertice pivote;
        public bool iniciado = false;

        public Accion(Transformacion transformacion, Figura3D elemento, float objetivo, float tiempoInicio, float duracion) //, Vertice pivote
        {
            this.transformacion = transformacion;
            this.elemento = elemento;
            this.objetivo = objetivo;
            this.tiempoInicio = tiempoInicio;
            this.duracion = duracion;
            //this.pivote = pivote;
        }

        public void Apply(float step)
        {
            //elemento.centro = pivote;
            iniciado = true;
            objetivo -= step;
            transformacion.Apply(elemento, step);
        }
    }
}
