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
    }
}
