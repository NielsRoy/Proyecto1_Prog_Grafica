using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoOpenTk
{
    internal class Game : GameWindow
    {
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        float theta = 0f;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);

        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.Translate(0.0f, 0.0f, -45.0f);
            //GL.Rotate(-20.0f, 0.0, 1.0, 0.0);
            //GL.Rotate(-15.0f, 1.0, 0.0, 0.0);
            GL.Rotate(theta, 0.0, 0.5, 0.0);


            GL.Color4(Color4.Blue);
            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-3f, 0f, -3f);
            GL.Vertex3(3f, 0f, -3f);
            GL.Vertex3(3f, 0f, 3f);
            GL.Vertex3(-3f, 0f, 3f);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-9f, 24f, 3f);
            GL.Vertex3(9f, 24f, 3f);
            GL.Vertex3(9f, 18f, 3f);
            GL.Vertex3(-9f, 18f, 3f);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(3f, 18f, 3f);
            GL.Vertex3(3f, 0f, 3f);
            GL.Vertex3(-3f, 0f, 3f);
            GL.Vertex3(-3f, 18f, 3f);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(3f, 0f, -3f);
            GL.Vertex3(3f, 0f, 3f);
            GL.Vertex3(3f, 18f, 3f);
            GL.Vertex3(3f, 18f, -3f);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-3f, 0f, 3f);
            GL.Vertex3(-3f, 0f, -3f);
            GL.Vertex3(-3f, 18f, -3f);
            GL.Vertex3(-3f, 18f, 3f);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-9f, 24f, 3f);
            GL.Vertex3(-9f, 24f, -3f);
            GL.Vertex3(9f, 24f, -3f);
            GL.Vertex3(9f, 24f, 3f);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-9f, 24f, -3f);
            GL.Vertex3(9f, 24f, -3f);
            GL.Vertex3(9f, 18f, -3f);
            GL.Vertex3(-9f, 18f, -3f);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(3f, 18f, -3f);
            GL.Vertex3(3f, 0f, -3f);
            GL.Vertex3(-3f, 0f, -3f);
            GL.Vertex3(-3f, 18f, -3f);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-9f, 24f, 3f);
            GL.Vertex3(-9f, 24f, -3f);
            GL.Vertex3(9f, 24f, -3f);
            GL.Vertex3(9f, 24f, 3f);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(9f, 24f, 3f);
            GL.Vertex3(9f, 24f, -3f);
            GL.Vertex3(9f, 18f, -3f);
            GL.Vertex3(9f, 18f, 3f);
            GL.End();

            GL.Begin(BeginMode.Polygon);
            GL.Vertex3(-9f, 24f, 3f);
            GL.Vertex3(-9f, 24f, -3f);
            GL.Vertex3(-9f, 18f, -3f);
            GL.Vertex3(-9f, 18f, 3f);
            GL.End();

            //----

            GL.Color4(Color4.Black);
            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-3f, 0f, -3f);
            GL.Vertex3(3f, 0f, -3f);
            GL.Vertex3(3f, 0f, 3f);
            GL.Vertex3(-3f, 0f, 3f);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-9f, 24f, 3f);
            GL.Vertex3(9f, 24f, 3f);
            GL.Vertex3(9f, 18f, 3f);
            GL.Vertex3(3f, 18f, 3f);
            GL.Vertex3(3f, 0f, 3f);
            GL.Vertex3(-3f, 0f, 3f);
            GL.Vertex3(-3f, 18f, 3f);
            GL.Vertex3(-9f, 18f, 3f);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(3f, 0f, -3f);
            GL.Vertex3(3f, 0f, 3f);
            GL.Vertex3(3f, 18f, 3f);
            GL.Vertex3(3f, 18f, -3f);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-3f, 0f, 3f);
            GL.Vertex3(-3f, 0f, -3f);
            GL.Vertex3(-3f, 18f, -3f);
            GL.Vertex3(-3f, 18f, 3f);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-9f, 24f, 3f);
            GL.Vertex3(-9f, 24f, -3f);
            GL.Vertex3(9f, 24f, -3f);
            GL.Vertex3(9f, 24f, 3f);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-9f, 24f, -3f);
            GL.Vertex3(9f, 24f, -3f);
            GL.Vertex3(9f, 18f, -3f);
            GL.Vertex3(3f, 18f, -3f);
            GL.Vertex3(3f, 0f, -3f);
            GL.Vertex3(-3f, 0f, -3f);
            GL.Vertex3(-3f, 18f, -3f);
            GL.Vertex3(-9f, 18f, -3f);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-9f, 24f, 3f);
            GL.Vertex3(-9f, 24f, -3f);
            GL.Vertex3(9f, 24f, -3f);
            GL.Vertex3(9f, 24f, 3f);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(9f, 24f, 3f);
            GL.Vertex3(9f, 24f, -3f);
            GL.Vertex3(9f, 18f, -3f);
            GL.Vertex3(9f, 18f, 3f);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-9f, 24f, 3f);
            GL.Vertex3(-9f, 24f, -3f);
            GL.Vertex3(-9f, 18f, -3f);
            GL.Vertex3(-9f, 18f, 3f);
            GL.End();

            theta += 1.0f;
            if (theta > 360) theta -= 360;

            Context.SwapBuffers();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            GL.Frustum(-1.0f, 1.0f, -1.0f, 1.0f, 0.8f, 100.0f);

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
    }
}
