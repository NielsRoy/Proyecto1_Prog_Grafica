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

            Escena e1 = new Escena(8000); //8 seg

            Transformacion t1 = new Transformacion(Transformacion.TRASLADAR, 1, 0, 0);
            Accion a1 = new Accion(
                t1,
                escenario.objetos["robot"],
                -15,
                1000,
                2000
            );

            Transformacion t2 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a2 = new Accion(
                t2,
                escenario.objetos["robot"].partes["pierna_derecha"],
                -50,
                1000,
                500
            );

            Transformacion t2_1 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a2_1 = new Accion(
                t2_1,
                escenario.objetos["robot"].partes["brazo_derecho"],
                50,
                1000,
                500
            );

            Transformacion t3 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a3 = new Accion(
                t3,
                escenario.objetos["robot"].partes["pierna_izquierda"],
                50,
                1000,
                500
            );

            Transformacion t3_1 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a3_1 = new Accion(
                t3_1,
                escenario.objetos["robot"].partes["brazo_izquierdo"],
                -50,
                1000,
                500
            );

            Transformacion t4 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a4 = new Accion(
                t4,
                escenario.objetos["robot"].partes["pierna_derecha"],
                50,
                1500,
                500
            );

            Transformacion t4_1 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a4_1 = new Accion(
                t4_1,
                escenario.objetos["robot"].partes["brazo_derecho"],
                -50,
                1500,
                500
            );

            Transformacion t5 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a5 = new Accion(
                t5,
                escenario.objetos["robot"].partes["pierna_izquierda"],
                -50,
                1500,
                500
            );

            Transformacion t5_1 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a5_1 = new Accion(
                t5_1,
                escenario.objetos["robot"].partes["brazo_izquierdo"],
                50,
                1500,
                500
            );

            Transformacion t6 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a6 = new Accion(
                t6,
                escenario.objetos["robot"].partes["pierna_derecha"],
                -50,
                2000,
                500
            );

            Transformacion t6_1 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a6_1 = new Accion(
                t6_1,
                escenario.objetos["robot"].partes["brazo_derecho"],
                50,
                2000,
                500
            );

            Transformacion t7 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a7 = new Accion(
                t7,
                escenario.objetos["robot"].partes["pierna_izquierda"],
                50,
                2000,
                500
            );

            Transformacion t7_1 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a7_1 = new Accion(
                t7_1,
                escenario.objetos["robot"].partes["brazo_izquierdo"],
                -50,
                2000,
                500
            );

            Transformacion t8 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a8 = new Accion(
                t8,
                escenario.objetos["robot"].partes["pierna_derecha"],
                25,
                2500,
                500
            );

            Transformacion t8_1 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a8_1 = new Accion(
                t8_1,
                escenario.objetos["robot"].partes["brazo_derecho"],
                -25,
                2500,
                500
            );

            Transformacion t9 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a9 = new Accion(
                t9,
                escenario.objetos["robot"].partes["pierna_izquierda"],
                -25,
                2500,
                500
            );

            Transformacion t9_1 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a9_1 = new Accion(
                t9_1,
                escenario.objetos["robot"].partes["brazo_izquierdo"],
                25,
                2500,
                500
            );

            Transformacion t10 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a10 = new Accion(
                t10,
                escenario.objetos["robot"].partes["brazo_derecho"],
                50,
                3000,
                500
            );

            Transformacion t11 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a11 = new Accion(
                t11,
                escenario.objetos["robot"].partes["brazo_izquierdo"],
                50,
                3000,
                500
            );

            Transformacion t12 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a12 = new Accion(
                t12,
                escenario.objetos["robot"].partes["brazo_derecho"],
                -230,
                3500,
                500
            );

            Transformacion t13 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a13 = new Accion(
                t13,
                escenario.objetos["robot"].partes["brazo_izquierdo"],
                -230,
                3500,
                500
            );

            Transformacion t14 = new Transformacion(Transformacion.TRASLADAR, 0, 1, 0);
            Accion a14 = new Accion(
                t14,
                escenario.objetos["robot"],
                30,
                3850,
                250
            );

            Transformacion t15 = new Transformacion(Transformacion.TRASLADAR, 1, 0, 0);
            Accion a15 = new Accion(
                t15,
                escenario.objetos["robot"],
                -10,
                4050,
                50
            );

            Transformacion t16 = new Transformacion(Transformacion.TRASLADAR, 1, 1, 0);
            Accion a16 = new Accion(
                t16,
                escenario.objetos["robot"],
                -10,
                4100,
                50
            );

            Transformacion t17 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a17 = new Accion(
                t17,
                escenario.objetos["robot"].partes["brazo_derecho"],
                180,
                4150,
                500
            );

            Transformacion t18 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a18 = new Accion(
                t18,
                escenario.objetos["robot"].partes["brazo_izquierdo"],
                180,
                4150,
                500
            );

            Transformacion t19 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a19 = new Accion(
                t19,
                escenario.objetos["robot"].partes["pierna_derecha"],
                50,
                4650,
                500
            );

            Transformacion t20 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a20 = new Accion(
                t20,
                escenario.objetos["robot"].partes["pierna_derecha"],
                -70,
                5150,
                250
            );

            //Mover balon

            Transformacion t21 = new Transformacion(Transformacion.TRASLADAR, 1, 0, 0);
            Accion a21 = new Accion(
                t21,
                escenario.objetos["balon"],
                -20,
                5400,
                1000
            );

            Transformacion t21_1 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a21_1 = new Accion(
                t21_1,
                escenario.objetos["balon"],
                360,
                5400,
                1000
            );

            Transformacion t22 = new Transformacion(Transformacion.ROTAR, 0, 0, 1);
            Accion a22 = new Accion(
                t22,
                escenario.objetos["robot"].partes["pierna_derecha"],
                -40,
                5400,
                250
            );

            e1.acciones.Add(a1);
            e1.acciones.Add(a2);
            e1.acciones.Add(a2_1);
            e1.acciones.Add(a3);
            e1.acciones.Add(a3_1);
            e1.acciones.Add(a4);
            e1.acciones.Add(a4_1);
            e1.acciones.Add(a5);
            e1.acciones.Add(a5_1);
            e1.acciones.Add(a6);
            e1.acciones.Add(a6_1);
            e1.acciones.Add(a7);
            e1.acciones.Add(a7_1);
            e1.acciones.Add(a8);
            e1.acciones.Add(a8_1);
            e1.acciones.Add(a9);
            e1.acciones.Add(a9_1);
            e1.acciones.Add(a10);
            e1.acciones.Add(a11);
            e1.acciones.Add(a12);
            e1.acciones.Add(a13);
            e1.acciones.Add(a14);
            e1.acciones.Add(a15);
            e1.acciones.Add(a16);
            e1.acciones.Add(a17);
            e1.acciones.Add(a18);
            e1.acciones.Add(a19);
            e1.acciones.Add(a20);
            e1.acciones.Add(a21);
            e1.acciones.Add(a21_1);
            e1.acciones.Add(a22);

            libreto.AddEscena(e1);

            return libreto;
        }
    }
}
