using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GK_rysowanie_odcinków
{
    public partial class Form1 : Form
    {
        private Options options = Options.Instance;
        private List<Drawable> drawables;
        private OriginPointer origin;

        private Stack<Vec2d> newLinePoints;

        public Form1()
        {
            InitializeComponent();
            newLinePoints = new Stack<Vec2d>(2);
            origin = new OriginPointer(0, 0);
            drawables = new List<Drawable>()
            {
                new Line(new Vec2d(), new Vec2d(100,50)),
                new Line(new Vec2d(0,100), new Vec2d(100,50)),
                new Line(new Vec2d(0,100), new Vec2d(50,200)),
                new Line(new Vec2d(0,300), new Vec2d(50,200)),

                new Line(new Vec2d(200,50), new Vec2d(100,0)),
                new Line(new Vec2d(200,50), new Vec2d(100,100)),
                new Line(new Vec2d(150,200), new Vec2d(100,100)),
                new Line(new Vec2d(150,200), new Vec2d(100,300)),

                new Line(new Vec2d(50,310), new Vec2d(0,310)),
                new Line(new Vec2d(0,320), new Vec2d(50,320)),

                new Line(new Vec2d(10,330), new Vec2d(10,380)),
                new Line(new Vec2d(20,330), new Vec2d(20,380)),

                origin,
            };

        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.White);
            foreach(var d in drawables)
            {
                d.Draw(e.Graphics);
            }
        }

        private void bUp_Click(object sender, EventArgs e)
        {
            foreach(Transformable<double> t in drawables.OfType<Transformable<double>>())
                t.Move(new Vec2<double>(0, -(double)nY.Value));
            canvas.Refresh();
        }

        private void bRight_Click(object sender, EventArgs e)
        {
            foreach (Transformable<double> t in drawables.OfType<Transformable<double>>())
                t.Move(new Vec2<double>((double)nX.Value, 0));
            canvas.Refresh();
        }

        private void bDown_Click(object sender, EventArgs e)
        {
            foreach (Transformable<double> t in drawables.OfType<Transformable<double>>())
                t.Move(new Vec2<double>(0, (double)nY.Value));
            canvas.Refresh();
        }

        private void bLeft_Click(object sender, EventArgs e)
        {
            foreach (Transformable<double> t in drawables.OfType<Transformable<double>>())
                t.Move(new Vec2<double>(-(double)nX.Value, 0));
            canvas.Refresh();
        }

        private void bUpRight_Click(object sender, EventArgs e)
        {
            bUp_Click(sender, e);
            bRight_Click(sender, e);
        }

        private void bDownRight_Click(object sender, EventArgs e)
        {
            bDown_Click(sender, e);
            bRight_Click(sender, e);
        }

        private void bDownLeft_Click(object sender, EventArgs e)
        {
            bDown_Click(sender, e);
            bLeft_Click(sender, e);
        }

        private void bUpLeft_Click(object sender, EventArgs e)
        {
            bUp_Click(sender, e);
            bLeft_Click(sender, e);
        }

        private void bScale_Click(object sender, EventArgs e)
        {
            foreach (Transformable<double> t in drawables.OfType<Transformable<double>>())
                t.Scale(new Vec2d((double)nScaleX.Value, (double)nScaleY.Value),origin.Position);
            canvas.Refresh();
        }

        private void bRotate_Click(object sender, EventArgs e)
        {

            foreach (Transformable<double> t in drawables.OfType<Transformable<double>>())
                t.Rotate((double)nAngle.Value*Math.PI/180f, origin.Position);
            canvas.Refresh();
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left: //create new line
                    newLinePoints.Push(new Vec2d(e.Location.X, e.Location.Y));
                    if(newLinePoints.Count == 2)
                    {
                        drawables.Add(new Line(newLinePoints.Pop(), newLinePoints.Pop()));
                        canvas.Refresh();
                    }
                    break;
                case MouseButtons.Right: //place origin
                    origin.Position = new Vec2d(e.Location.X, e.Location.Y);
                    canvas.Refresh();
                    break;
            }
        }

        private void bClearCanvas_Click(object sender, EventArgs e)
        {
            drawables.Clear();
            drawables.Add(origin);
            canvas.Refresh();
        }

        private void rPrzyrostowy_CheckedChanged(object sender, EventArgs e)
        {
            options.LineDrawingAlgorithm = LineDrawingAlgorithms.Przyrostowy;
            canvas.Refresh();
        }

        private void rWu_CheckedChanged(object sender, EventArgs e)
        {
            options.LineDrawingAlgorithm = LineDrawingAlgorithms.Wu;
            canvas.Refresh();
        }
    }
}
