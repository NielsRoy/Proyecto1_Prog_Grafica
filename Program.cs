using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Game game = new Game(800, 600, "OpenTK - Hola Mundo"))
            {
                game.Run(60.0);
            }
        }
    }
}
