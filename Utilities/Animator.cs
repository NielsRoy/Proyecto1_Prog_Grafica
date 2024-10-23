using ProyectoOpenTk.EstructuraAnimacion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ProyectoOpenTk.Utilities
{
    public class Animator
    {
        public Libreto libreto;
        const float fpsTarget = 120;
        //milisegundos
        public float tiempoTranscurrido = 0;
        private long quantum = 10;    

        private float fps = fpsTarget / 1000;
        private float spf = 1000 / fpsTarget;
        //usar double ?
        private void Animate()
        {
            Console.WriteLine("Inicio animacion");
            Stopwatch timer = new Stopwatch();
            Escena escena = libreto.getNextEscena();
            float duracionEscena = escena.duracion;
            Stopwatch quantumController = new Stopwatch();
            timer.Start();
            while (tiempoTranscurrido < libreto.duracion)
            {
                while (tiempoTranscurrido < duracionEscena && tiempoTranscurrido < libreto.duracion)
                {
                    List<Accion> acciones = new List<Accion>(escena.acciones);
                    foreach (Accion accion in acciones)
                    {
                        if (accion.duracion <= 0)
                        {
                            escena.removeAccion(accion);
                            continue;
                        }
                        if (tiempoTranscurrido < accion.tiempoInicio) continue;

                        float currentQuantum = 0;
                        quantumController.Start();
                        float tiempoPorFrame = 0;
                        while (currentQuantum < quantum)
                        {
                            if (currentQuantum >= tiempoPorFrame)
                            { 
                                float step = accion.objetivo / (fps * accion.duracion);
                                accion.Apply(step);
                                tiempoPorFrame += spf;
                            }
                            
                            currentQuantum = (float)quantumController.Elapsed.TotalMilliseconds;
                        }
                        escena.actualizarDuracionAcciones(currentQuantum);
                        quantumController.Reset();
                        tiempoTranscurrido = (float)timer.Elapsed.TotalMilliseconds;
                    }
                    tiempoTranscurrido = (float)timer.Elapsed.TotalMilliseconds;
                }
                escena = libreto.getNextEscena();
                duracionEscena += escena?.duracion ?? 0;
                tiempoTranscurrido = (float)timer.Elapsed.TotalMilliseconds;
            }
            Console.WriteLine("Fin animacion");
        }

        public void Run(Libreto libreto)
        {
            this.libreto = libreto;
            Thread hilo = new Thread(new ThreadStart(Animate));
            hilo.Start();
        }
    }
}
