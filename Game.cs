using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using ProyectoOpenTk.Estructura3D;
using ProyectoOpenTk.EstructuraAnimacion;
using ProyectoOpenTk.Utilities;
using System;

namespace ProyectoOpenTk
{
    public class Game : GameWindow
    {
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        Escenario escenario = new Escenario(0, 0, 0);
        Animator animator = new Animator();
        Libreto libreto;

        bool running = true;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);


            //Objeto T = Serializer.LoadObj("T.obj");
            //Objeto human = Serializer.LoadObj("robot.obj");
            //Objeto ball = Serializer.LoadObj("balon.obj");

            //escenario.objetos.Add("T", T);
            //escenario.objetos.Add("robot", human);
            //escenario.objetos.Add("balon", ball);

            escenario = Serializer.LoadJson<Escenario>("escenario2.json");
            escenario.objetos["balon"].SetCenterToGeometry();
            //TODO: Agregar centro de masa al balon

            //escenario.objetos["humano"].partes["brazo_derecho.001"].centro.setValues(16.722f, 14.5275f, 3.7549f);
            //escenario.objetos["humano"].partes["brazo_izquierdo.001"].centro.setValues(17.6436f, 14.5025f, -3.70694f);
            //escenario.objetos["humano"].partes["pierna_derecha.001"].centro.setValues(17.4069f, 8.66231f, 1.2785f);
            //escenario.objetos["humano"].partes["pierna_izquierda.001"].centro.setValues(16.8673f, 8.63649f, -1.28736f);
            //Serializer.SaveJson(escenario, "escenario2.json");
            libreto = Animacion.getLibreto(escenario);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            
            GL.LoadIdentity();
            GL.Translate(0, 0, -60);
            GL.Rotate(20, 1, 0, 0);

            //GL.Rotate(theta, 0, 1, 0);

            escenario.Draw();

            //theta += 1.0f;
            //if (theta > 360) theta -= 360;

            Context.SwapBuffers();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Frustum(-1, 1, -1, 1, 1, 100);

            GL.MatrixMode(MatrixMode.Modelview);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            KeyboardState input = Keyboard.GetState();

            if (input.IsKeyDown(Key.Escape))
            {
                Exit();
            }

            if (running && input.IsKeyDown(Key.Space))
            {
                Console.WriteLine("Animacion");
                animator.Run(libreto);
                running = false;
            }
        }
    }
}
