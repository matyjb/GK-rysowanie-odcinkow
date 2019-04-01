using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SFML;
using SFML.System;
using SFML.Graphics;
using SFML.Window;

namespace GK_rysowanie_odcinków
{
    public partial class SFMLCanvasControl : UserControl
    {
        private RenderWindow RendWind;

        public SFMLCanvasControl()
        {
            InitializeComponent();
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

        private void DrawStuff()
        {
            CircleShape CS = new CircleShape(10);
            CS.FillColor = Color.Magenta;
            RendWind.Draw(CS);
        }

        private void RenderLoopWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RendWind = new RenderWindow((IntPtr)e.Argument);
            RendWind.Resized += RendWind_Resized;
            while (RendWind.IsOpen)
            {
                RendWind.DispatchEvents();
                RendWind.Clear(Color.Black);
                DrawStuff();
                RendWind.Display();
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
