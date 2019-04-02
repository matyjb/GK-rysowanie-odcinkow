using System;
using System.Windows.Forms;

namespace GK_rysowanie_odcinków
{
    public partial class Form1 : Form
    {
        private Options options = Options.Instance;

        public Form1()
        {
            InitializeComponent();
            canvas.StartSLMF();
        }

        private void bUp_Click(object sender, EventArgs e)
        {
            canvas.MoveObjects(new SFML.System.Vector2f(0, -(float)nY.Value));
        }

        private void bRight_Click(object sender, EventArgs e)
        {
            canvas.MoveObjects(new SFML.System.Vector2f((float)nX.Value, 0));
        }

        private void bDown_Click(object sender, EventArgs e)
        {
            canvas.MoveObjects(new SFML.System.Vector2f(0, (float)nY.Value));
        }

        private void bLeft_Click(object sender, EventArgs e)
        {
            canvas.MoveObjects(new SFML.System.Vector2f(-(float)nX.Value, 0));
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
            canvas.ScaleObjects(new SFML.System.Vector2f((float)nScaleX.Value, (float)nScaleY.Value));

        }

        private void bRotate_Click(object sender, EventArgs e)
        {
            canvas.RotateObjects((float)nAngle.Value*(float)Math.PI/180f);
        }

        private void bClearCanvas_Click(object sender, EventArgs e)
        {
            while (canvas.drawablesPadlock) { } //wait till drawing is complete
            canvas.ClearCanvas();
        }

        private void rPrzyrostowy_CheckedChanged(object sender, EventArgs e)
        {
            options.LineDrawingAlgorithm = LineDrawingAlgorithms.Przyrostowy;
        }

        private void rWu_CheckedChanged(object sender, EventArgs e)
        {
            options.LineDrawingAlgorithm = LineDrawingAlgorithms.Wu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PPM - ustawienie punktu środka\nLPM - rysowanie linii");
        }
    }
}
