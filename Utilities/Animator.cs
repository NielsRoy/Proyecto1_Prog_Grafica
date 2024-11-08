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
        const float fpsTarget = 60;
        //milisegundos
        public double tiempoTranscurrido = 0;
        private int quantum = 10;    

        private float fps = fpsTarget / 1000;
        private float spf = 1000 / fpsTarget;

        private Stopwatch timer = new Stopwatch();

        private void Animate()
        {
            Console.WriteLine("Inicio animacion");

            timer.Start();
            while (tiempoTranscurrido < libreto.duracion)
            {
                Escena escena = libreto.getNextEscena();
                if (escena != null)
                {
                    Execute(escena);
                    Console.WriteLine("Escena ejecutada");
                }
                tiempoTranscurrido = timer.Elapsed.TotalMilliseconds;
            }
            timer.Reset();

            Console.WriteLine("Fin animacion");
        }

        private void Execute(Escena e)
        {
            e.EliminarAccionesSinDuracion();
            Stopwatch quantumController = new Stopwatch();
            List<Accion> acciones = e.acciones;
            while (DentroDelTiempo(e))
            {
                int i = 0;
                while (DentroDelTiempo(e) && i < acciones.Count)
                {
                    Accion a = acciones[i];
                    if (a.tiempoRestante <= 0) { 
                        i++;
                        continue; 
                    }

                    if (tiempoTranscurrido < a.tiempoInicio) {
                        i++;
                        continue;
                    }

                    double currentQuantum = 0;
                    double tiempoPorFrame = 0;
                    quantumController.Start();
                    while (DentroDelTiempo(e) && currentQuantum < quantum)
                    {
                        if (currentQuantum >= tiempoPorFrame)
                        {
                            a.Run(fps);
                            tiempoPorFrame += spf;
                        }
                        currentQuantum = quantumController.Elapsed.TotalMilliseconds;
                    }
                    tiempoTranscurrido = timer.Elapsed.TotalMilliseconds;
                    e.actualizarTiempoAcciones(tiempoTranscurrido);
                    quantumController.Reset();

                    i++;
                }
            }
        }

        public bool DentroDelTiempo(Escena e)
        {
            tiempoTranscurrido = timer.Elapsed.TotalMilliseconds;
            return tiempoTranscurrido < libreto.duracion && tiempoTranscurrido < e.duracion;
        }

        public void Run(Libreto libreto)
        {
            this.libreto = libreto;
            Thread hilo = new Thread(new ThreadStart(Animate));
            hilo.Start();
        }
    }
}
