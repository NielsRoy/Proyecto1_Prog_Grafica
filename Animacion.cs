using ProyectoOpenTk.Estructura3D;
using ProyectoOpenTk.EstructuraAnimacion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk
{
    public class Animacion
    {
        public static Libreto getLibreto(Escenario escenario)
        {
            Libreto libreto = new Libreto(10000); //10 seg

            Escena e1 = new Escena(8000); //7 seg

            Transformacion t1 = new Transformacion(Transformacion.TRASLADAR, 1, 0, 0);
            Accion a1 = new Accion(
                t1,
                escenario.objetos["humano"],
                -10,
                1000,
                3000
            );

            Transformacion t2 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a2 = new Accion(
                t2,
                escenario.objetos["humano"].partes["pierna_derecha.001"],
                35,
                1000,
                1000
            );

            Transformacion t3 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a3 = new Accion(
                t3,
                escenario.objetos["humano"].partes["pierna_izquierda.001"],
                -35,
                1000,
                1000
            );

            Transformacion t4 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a4 = new Accion(
                t4,
                escenario.objetos["humano"].partes["pierna_derecha.001"],
                -35,
                2000,
                1000
            );

            Transformacion t5 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a5 = new Accion(
                t5,
                escenario.objetos["humano"].partes["pierna_izquierda.001"],
                35,
                2000,
                1000
            );

            Transformacion t6 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a6 = new Accion(
                t6,
                escenario.objetos["humano"].partes["pierna_derecha.001"],
                35,
                3000,
                1000
            );

            Transformacion t7 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a7 = new Accion(
                t7,
                escenario.objetos["humano"].partes["pierna_izquierda.001"],
                -35,
                3000,
                1000
            );

            e1.acciones.Add(a1);
            e1.acciones.Add(a2);
            e1.acciones.Add(a3);
            e1.acciones.Add(a4);
            e1.acciones.Add(a5);
            e1.acciones.Add(a6);
            e1.acciones.Add(a7);



            libreto.AddEscena(e1);
            
            //Escena e2 = new Escena(2000); //3 seg

            //libreto.escenas.Add();

            return libreto;
        }
    }
}
