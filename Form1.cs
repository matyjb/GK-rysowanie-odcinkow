using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK_rysowanie_odcinków
{
    public partial class Form1 : Form
    {
        private List<Drawable> drawables;

        public Form1()
        {
            InitializeComponent();
            drawables = new List<Drawable>()
            {
                new Line(new Vec2i(), new Vec2i(100,50)),
                new Line(new Vec2i(0,100), new Vec2i(100,50)),
                new Line(new Vec2i(0,100), new Vec2i(50,200)),
                new Line(new Vec2i(0,300), new Vec2i(50,200)),

                new Line(new Vec2i(200,50), new Vec2i(100,0)),
                new Line(new Vec2i(200,50), new Vec2i(100,100)),
                new Line(new Vec2i(150,200), new Vec2i(100,100)),
                new Line(new Vec2i(150,200), new Vec2i(100,300)),

                new Line(new Vec2i(50,310), new Vec2i(0,310)),
                new Line(new Vec2i(0,320), new Vec2i(50,320)),

                new Line(new Vec2i(10,330), new Vec2i(10,380)),
                new Line(new Vec2i(20,330), new Vec2i(20,380)),
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
            foreach(Transformable<int> t in drawables)  t.Move(new Vec2<int>(0, -(int)nY.Value));
            canvas.Refresh();
        }

        private void bRight_Click(object sender, EventArgs e)
        {
            foreach (Transformable<int> t in drawables) t.Move(new Vec2<int>((int)nX.Value, 0));
            canvas.Refresh();
        }

        private void bDown_Click(object sender, EventArgs e)
        {
            foreach (Transformable<int> t in drawables) t.Move(new Vec2<int>(0, (int)nY.Value));
            canvas.Refresh();
        }

        private void bLeft_Click(object sender, EventArgs e)
        {
            foreach (Transformable<int> t in drawables) t.Move(new Vec2<int>(-(int)nX.Value, 0));
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
    }
}
