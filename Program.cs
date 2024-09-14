using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Form1 form = new Form1();
            //form.ShowDialog();

            using (Game game = new Game(800, 600, "OpenTK - Hola Mundo"))
            {
                game.Run(60.0);
            }
        }
    }
}
