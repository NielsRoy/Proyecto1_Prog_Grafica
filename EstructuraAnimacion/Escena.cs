using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk.EstructuraAnimacion
{
    public class Escena
    {
        public List<Accion> acciones = new List<Accion>();
        public double duracion;

        private double tiempoTranscurrido;

        public Escena(long duracion)
        {
            this.duracion = duracion;
        }

        public void Run()
        {

        }

        public void actualizarDuracionAcciones(double tiempoTranscurrido)
        {
            foreach (Accion accion in acciones)
            {
                if (!accion.iniciado) continue;
                accion.duracion -= tiempoTranscurrido;
            }
        }

        public void actualizarTiempoAcciones(double tiempoTranscurrido)
        {
            foreach (Accion a in acciones)
            {
                if (tiempoTranscurrido <= a.tiempoInicio) continue;
                a.tiempoRestante = (a.tiempoInicio + a.duracion) - tiempoTranscurrido;
            }
        }

        public void EliminarAccionesSinDuracion()
        {
            foreach (Accion accion in acciones)
            {
                if (accion.duracion <= 0)
                {
                    acciones.Remove(accion);
                }
            }
        }

        public void removeAccion(Accion accion)
        {
            acciones.Remove(accion);
        }


    }
}
