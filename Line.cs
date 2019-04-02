using System;
using SFML;
using SFML.Graphics;
using SFML.System;

namespace GK_rysowanie_odcinków
{
    class Line : ITransformable, Drawable
    {
        public Vector2f P1 { get; set; }
        public Vector2f P2 { get; set; }
        private Color Color = Color.Black;

        public Line(Vector2f p1, Vector2f p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public void Move(Vector2f by)
        {
            P1 += by;
            P2 += by;
        }

        public void Rotate(double angle, Vector2f origin)
        {
            Move(-origin);
            double xp = P1.X * Math.Cos(angle) - P1.Y * Math.Sin(angle);
            double yp = P1.X * Math.Sin(angle) + P1.Y * Math.Cos(angle);
            P1 = new Vector2f((float)xp, (float)yp);
            xp = P2.X * Math.Cos(angle) - P2.Y * Math.Sin(angle);
            yp = P2.X * Math.Sin(angle) + P2.Y * Math.Cos(angle);
            P2 = new Vector2f((float)xp, (float)yp);
            Move(origin);
        }

        public void Scale(Vector2f by, Vector2f origin)
        {
            Move(-origin);
            P1 = new Vector2f(P1.X * by.X, P1.Y * by.Y);
            P2 = new Vector2f(P2.X * by.X, P2.Y * by.Y);
            Move(origin);
        }

        //help functions
        static private int ipart(double x) { return (int)x; }

        static private int round(double x) { return ipart(x + 0.5); }

        static private float fpart(float x)
        {
            if (x < 0) return 1 - (float)(x - Math.Floor(x));
            return (float)(x - Math.Floor(x));
        }

        static private float rfpart(float x)
        {
            return 1 - fpart(x);
        }

        static private void swap(ref float o1, ref float o2)
        {
            float tmp = o1;
            o1 = o2;
            o2 = tmp;
        }

        private void SetPixel(RenderTarget target, int x, int y, Color color)
        {
            target.Draw(new Vertex[] { new Vertex(new Vector2f(x, y), color)}, PrimitiveType.Points);
        }
        public void Draw(RenderTarget target, RenderStates states)
        {
            switch (Options.Instance.LineDrawingAlgorithm)
            {
                case LineDrawingAlgorithms.Przyrostowy:

                    float m;
                    if (P2.X - P1.X != 0) m = (P2.Y - P1.Y) / (P2.X - P1.X);
                    else m = P2.Y - P1.Y;
                    Color.A = 255;
                    if (Math.Abs(m) >= 1)
                    {
                        Vector2f start = P1.Y < P2.Y ? P1 : P2;
                        Vector2f end = P1.Y >= P2.Y ? P1 : P2;

                        float x = start.X;
                        for (float y = start.Y; y <= end.Y; y++)
                        {
                            SetPixel(target, (int)Math.Round(x), Convert.ToInt32(y), Color);
                            x += (P2.X - P1.X != 0) ? 1 / m : 0;
                        }
                    }
                    else
                    {
                        Vector2f start = P1.X < P2.X ? P1 : P2;
                        Vector2f end = P1.X >= P2.X ? P1 : P2;

                        float y = start.Y;
                        for (float x = start.X; x <= end.X; x++)
                        {
                            SetPixel(target, Convert.ToInt32(x), (int)Math.Round(y), Color);
                            y += m;
                        }
                    }
                    break;
                case LineDrawingAlgorithms.Wu:

                    float x0 = P1.X;
                    float x1 = P2.X;
                    float y0 = P1.Y;
                    float y1 = P2.Y;
                    bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);

                    // swap the co-ordinates if slope > 1 or we 
                    // draw backwards 
                    if (steep)
                    {
                        swap(ref x0, ref y0);
                        swap(ref x1, ref y1);
                    }
                    if (x0 > x1)
                    {
                        swap(ref x0, ref x1);
                        swap(ref y0, ref y1);
                    }

                    //compute the slope 
                    float dx = x1 - x0;
                    float dy = y1 - y0;
                    float gradient = dx == 0 ? 1 : dy / dx;

                    int xpxl1 = ipart(x0);
                    int xpxl2 = ipart(x1);
                    float intersectY = y0;

                    // main loop 
                    if (steep)
                    {
                        for (int x = xpxl1; x <= xpxl2; x++)
                        {
                            Color.A = (byte)(fpart(intersectY)*255);
                            SetPixel(target,ipart(intersectY), x, Color);
                            Color.A = (byte)(rfpart(intersectY) * 255);
                            SetPixel(target, ipart(intersectY)-1, x, Color);
                            intersectY += gradient;
                        }
                    }
                    else
                    {
                        for (int x = xpxl1; x <= xpxl2; x++)
                        {
                            Color.A = (byte)(fpart(intersectY) * 255);
                            SetPixel(target, x, ipart(intersectY), Color);
                            Color.A = (byte)(rfpart(intersectY) * 255);
                            SetPixel(target, x, ipart(intersectY) - 1, Color);
                            intersectY += gradient;
                        }
                    }
                    break;
            }
        }
    }
}
