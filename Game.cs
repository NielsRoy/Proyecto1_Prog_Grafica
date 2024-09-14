using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using ProyectoOpenTk.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ProyectoOpenTk
{
    public class Game : GameWindow
    {
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        float theta = 0f;

        Escenario esc = new Escenario(3, 0, 0);

        Stopwatch stopwatch = new Stopwatch();
        const float maxFps = 30;
        const float animationDuration = 5;
        const float animationDurationMilliseconds = 5000;
        //float startAngle = 0f;
        const float totalRotation = 720;
        const float step = totalRotation / (maxFps * animationDuration);

        const float deltaTime = 1000 / maxFps;
        float currentTimeLimit = deltaTime;

        float c = 0;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);

            cargarEscenario(esc);
            //esc = Serializer.Load<Escenario>("escenario1.json");

            //Serializer.save(esc, "escenario1.json");
            stopwatch.Start();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            
            GL.LoadIdentity();
            GL.Translate(0, 0, -50);
            //GL.Rotate(theta, 0.0, 0.5, 0.0);

            //esc.Translate(1,0,0);
            esc.Draw();
            
            if (stopwatch.Elapsed.TotalMilliseconds < animationDurationMilliseconds)
            {
                float elapsedTime = (float)stopwatch.Elapsed.TotalMilliseconds;
                //Console.WriteLine(elapsedTime.ToString());
                //float progress = elapsedTime / animationDuration;
                if (elapsedTime > currentTimeLimit)
                {
                    Console.WriteLine(currentTimeLimit);

                    //esc.Rotate(step, 0, 1, 0);
                    //esc.objetos["T"].Rotate(step, 0, 1, 0);
                    esc.objetos["T"].partes["cabeza"].Rotate(step, 0, 1, 0);


                    c++;
                    Console.WriteLine(c);
                    
                    currentTimeLimit += deltaTime;
                }
            }

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
        }

        private void cargarEscenario(Escenario e)
        {
            Objeto obj = new Objeto(5, -10, 0);
            e.AddObjeto("T", obj);    

            Parte superior = new Parte(0, 0, 0);
            obj.AddParte("cabeza", superior);

            Poligono p1 = new Poligono(Color4.Blue);
            p1.AddVertice(-9, 24, 3);
            p1.AddVertice(-9, 24, -3);
            p1.AddVertice(-9, 18, -3);
            p1.AddVertice(-9, 18, 3);
            superior.AddPoligono(p1);

            Poligono p2 = new Poligono(Color4.Green);
            p2.AddVertice(-9, 24, 3);
            p2.AddVertice(9, 24, 3);
            p2.AddVertice(9, 18, 3);
            p2.AddVertice(-9, 18, 3);
            superior.AddPoligono(p2);

            Poligono p3 = new Poligono(Color4.Green);
            p3.AddVertice(-9, 18, 3);
            p3.AddVertice(-9, 18, -3);
            p3.AddVertice(9, 18, -3);
            p3.AddVertice(9, 18, 3);
            superior.AddPoligono(p3);

            Poligono p4 = new Poligono(Color4.Aquamarine);
            p4.AddVertice(-9, 18, -3);
            p4.AddVertice(-9, 24, -3);
            p4.AddVertice(9, 24, -3);
            p4.AddVertice(9, 18, -3);
            superior.AddPoligono(p4);

            Poligono p5 = new Poligono(Color4.Green);
            p5.AddVertice(-9, 24, 3);
            p5.AddVertice(-9, 24, -3);
            p5.AddVertice(9, 24, -3);
            p5.AddVertice(9, 24, 3);
            superior.AddPoligono(p5);

            Poligono p6 = new Poligono(Color4.Green);
            p6.AddVertice(9, 24, 3);
            p6.AddVertice(9, 24, -3);
            p6.AddVertice(9, 18, -3);
            p6.AddVertice(9, 18, 3);
            superior.AddPoligono(p6);



            Parte inferior = new Parte(5, -5, 0);
            obj.AddParte("cuerpo", inferior);

            Poligono p7 = new Poligono(Color4.Yellow);
            p7.AddVertice(-3, 18, 3);
            p7.AddVertice(3, 18, 3);
            p7.AddVertice(3, 0, 3);
            p7.AddVertice(-3, 0, 3);
            inferior.AddPoligono(p7);

            Poligono p8 = new Poligono(Color4.Coral);
            p8.AddVertice(-3, 18, -3);
            p8.AddVertice(3, 18, -3);
            p8.AddVertice(3, 0, -3);
            p8.AddVertice(-3, 0, -3);
            inferior.AddPoligono(p8);

            Poligono p9 = new Poligono(Color4.Yellow);
            p9.AddVertice(-3, 18, 3);
            p9.AddVertice(-3, 18, -3);
            p9.AddVertice(-3, 0, -3);
            p9.AddVertice(-3, 0, 3);
            inferior.AddPoligono(p9);

            Poligono p10 = new Poligono(Color4.Yellow);
            p10.AddVertice(3, 18, 3);
            p10.AddVertice(3, 18, -3);
            p10.AddVertice(3, 0, -3);
            p10.AddVertice(3, 0, 3);
            inferior.AddPoligono(p10);

            Poligono p11 = new Poligono(Color4.Yellow);
            p11.AddVertice(-3, 18, 3);
            p11.AddVertice(-3, 18, -3);
            p11.AddVertice(3, 18, -3);
            p11.AddVertice(3, 18, 3);
            inferior.AddPoligono(p11);

            Poligono p12 = new Poligono(Color4.Yellow);
            p12.AddVertice(-3, 0, 3);
            p12.AddVertice(-3, 0, -3);
            p12.AddVertice(3, 0, -3);
            p12.AddVertice(3, 0, 3);
            inferior.AddPoligono(p12);

        }
    }
}
