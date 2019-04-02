using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using SFML.System;
using SFML.Graphics;
using SFML.Window;

namespace GK_rysowanie_odcinków
{
    public partial class SFMLCanvasControl : UserControl
    {
        private RenderWindow RendWind;
        public List<Drawable> drawables;
        public bool drawablesPadlock = false;
        private OriginPointer origin;
        private bool LPMPressed = false;
        private Vector2f LPMPressPosition = new Vector2f();
        
        public void MoveObjects(Vector2f by)
        {
            foreach (ITransformable t in drawables.OfType<ITransformable>())
                t.Move(by);
        }
        public void ScaleObjects(Vector2f by)
        {
            foreach (ITransformable t in drawables.OfType<ITransformable>())
                t.Scale(by, origin.Position);
        }
        public void RotateObjects(float angle)
        {
            foreach (ITransformable t in drawables.OfType<ITransformable>())
                t.Rotate(angle, origin.Position);
        }
        public void ClearCanvas()
        {
            drawablesPadlock = true;
            drawables.Clear();
            drawables.Add(origin);
            drawablesPadlock = false;
        }
        public SFMLCanvasControl()
        {
            InitializeComponent();
            origin = new OriginPointer(0, 0);
            drawables = new List<Drawable>()
            {
                new Line(new Vector2f(), new Vector2f(100,50)),
                new Line(new Vector2f(0,100), new Vector2f(100,50)),
                new Line(new Vector2f(0,100), new Vector2f(50,200)),
                new Line(new Vector2f(0,300), new Vector2f(50,200)),

                new Line(new Vector2f(200,50), new Vector2f(100,0)),
                new Line(new Vector2f(200,50), new Vector2f(100,100)),
                new Line(new Vector2f(150,200), new Vector2f(100,100)),
                new Line(new Vector2f(150,200), new Vector2f(100,300)),

                new Line(new Vector2f(50,310), new Vector2f(0,310)),
                new Line(new Vector2f(0,320), new Vector2f(50,320)),

                new Line(new Vector2f(10,330), new Vector2f(10,380)),
                new Line(new Vector2f(20,330), new Vector2f(20,380)),

                origin,
            };
        }

        public void StartSLMF()
        {
            if (!renderLoopWorker.IsBusy)
            {
                renderLoopWorker.RunWorkerAsync(Handle);
            }
        }

        private void RendWind_Resized(object sender, SizeEventArgs e)
        {
            FloatRect visibleArea = new FloatRect(0, 0, e.Width, e.Height);
            RendWind.SetView(new SFML.Graphics.View(visibleArea));
        }

        private void DrawLoop()
        {
            if (!drawablesPadlock)
            {
                drawablesPadlock = true;
                foreach(Drawable d in drawables)
                    RendWind.Draw(d);
                drawablesPadlock = false;
            }
            if (LPMPressed)
            {
                Line l = new Line(LPMPressPosition, (Vector2f)Mouse.GetPosition(RendWind));
                RendWind.Draw(l);
            }
        }

        private void RenderLoopWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RendWind = new RenderWindow((IntPtr)e.Argument);
            RendWind.Resized += RendWind_Resized;
            RendWind.MouseButtonPressed += RendWind_MouseButtonPressed;
            RendWind.MouseButtonReleased += RendWind_MouseButtonReleased;
            RendWind.SetFramerateLimit(0);
            while (RendWind.IsOpen)
            {
                RendWind.DispatchEvents();
                RendWind.Clear(Color.White);
                DrawLoop();
                RendWind.Display();
            }
        }

        private void RendWind_MouseButtonReleased(object sender, MouseButtonEventArgs e)
        {
            if (e.Button == Mouse.Button.Left)
            {
                LPMPressed = false;
                drawables.Add(new Line(LPMPressPosition, new Vector2f(e.X, e.Y)));
            }
        }

        private void RendWind_MouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            if(e.Button == Mouse.Button.Left)
            {
                LPMPressed = true;
                LPMPressPosition = new Vector2f(e.X, e.Y);
            }
            if(e.Button == Mouse.Button.Right)
            {
                origin.Position = new Vector2f(e.X, e.Y);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (RendWind == null)
                base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (RendWind == null)
                base.OnPaintBackground(pevent);
        }
    }
}
