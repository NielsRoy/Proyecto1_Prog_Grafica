using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk.EstructuraAnimacion
{
    public class Libreto
    {
        public List<Escena> escenas = new List<Escena>();    //Deberia ser privado pero ¿y la serializacion?
        public float duracion;  //Tiempo en milisegundos
        private int currentIndex = -1;

        public Libreto(float duracion)
        {
            this.duracion = duracion;
        }

        public void AddEscena(Escena escena)
        {
            if (escena.duracion > duracion) return;   //O no es necesario ?

            escenas.Add(escena);
            //escenas.Enqueue(escena);
        }

        //public Escena getNextEscena()
        //{
        //    return escenas.Dequeue();
        //}

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
            currentIndex++;
            return (currentIndex < escenas.Count) ? escenas[currentIndex] : null;
        }
    }
}
