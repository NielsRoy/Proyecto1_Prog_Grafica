using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk.EstructuraAnimacion
{
    public class Libreto
    {
        public List<Escena> escenas = new List<Escena>();
        public float duracion;  //Tiempo en milisegundos
        private int currentIndex = -1;

        public Libreto(float duracion)
        {
            this.duracion = duracion;
        }

        public void AddEscena(Escena escena)
        {
            if (escena.duracion > duracion) return;

            escenas.Add(escena);
        }

        public void RemoveEscena(Escena escena)
        {
            escenas.Remove(escena);
        }

        public void RemoveEscena(int index)
        {
            escenas.RemoveAt(index);
        }

        public Escena getNextEscena()
        {
            if (currentIndex >= escenas.Count) return null;
            currentIndex++;
            return (currentIndex < escenas.Count) ? escenas[currentIndex] : null;
        }
    }
}
