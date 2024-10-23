using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk.EstructuraAnimacion
{
    public class Escena
    {
        public List<Accion> acciones = new List<Accion>();
        //public float tiempoInicio; //Varias escenas al mismo tiempo ?? un escena sucede luego recien otra
        public float duracion;

        public Escena(long duracion)
        {
            this.duracion = duracion;
        }

        public void actualizarDuracionAcciones(float tiempoTranscurrido)
        {
            foreach (Accion accion in acciones)
            {
                if (!accion.iniciado) continue;
                accion.duracion -= tiempoTranscurrido;
            }
        }

        public void removeAccion(Accion accion)
        {
            acciones.Remove(accion);
        }
    }
}
