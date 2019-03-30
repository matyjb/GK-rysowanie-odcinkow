using System;
using System.Drawing;

namespace GK_rysowanie_odcinków
{
    class Line : Transformable<double>, Drawable
    {
        public Vec2d P1 { get; set; }
        public Vec2d P2 { get; set; }
        private Color Color = Color.Black;
        private SolidBrush Brush;

        public Line(Vec2d p1, Vec2d p2)
        {
            P1 = p1;
            P2 = p2;
            Brush = new SolidBrush(Color);
        }

        public void Draw(Graphics g)
        {
            switch (Options.Instance.LineDrawingAlgorithm)
            {
                case LineDrawingAlgorithms.Przyrostowy:

                    double m;
                    if (P2.X - P1.X != 0) m = (P2.Y - P1.Y) / (P2.X - P1.X);
                    else m = P2.Y - P1.Y;

                    if (Math.Abs(m) >= 1)
                    {
                        Vec2d start = P1.Y < P2.Y ? P1 : P2;
                        Vec2d end = P1.Y >= P2.Y ? P1 : P2;

                        double x = start.X;
                        for (double y = start.Y; y <= end.Y; y++)
                        {
                            SetPixel(g, (int)Math.Round(x), Convert.ToInt32(y), Color.Black);
                            x += (P2.X - P1.X != 0) ? 1 / m : 0;
                        }
                    }
                    else
                    {
                        Vec2d start = P1.X < P2.X ? P1 : P2;
                        Vec2d end = P1.X >= P2.X ? P1 : P2;

                        double y = start.Y;
                        for (double x = start.X; x <= end.X; x++)
                        {
                            SetPixel(g, Convert.ToInt32(x), (int)Math.Round(y), Color.Black);
                            y += m;
                        }
                    }
                    break;
                case LineDrawingAlgorithms.Wu:
                    
                    double x0 = P1.X;
                    double x1 = P2.X;
                    double y0 = P1.Y;
                    double y1 = P2.Y;



                    //start of algorithm
                    bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
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

                    double dx = x1 - x0;
                    double dy = y1 - y0;
                    double gradient = dx == 0 ? 1 : dy / dx;


                    //start point
                    double xEnd = round(x0);
                    double yEnd = y0 + gradient * (xEnd - x0);
                    double xGap = rfpart(x0 + 0.5);
                    double xPixel1 = xEnd;
                    double yPixel1 = ipart(yEnd);


                    Color c1 = Color.FromArgb((int)(rfpart(yEnd) * xGap * 255), Color);
                    Color c2 = Color.FromArgb((int)(fpart(yEnd) * xGap * 255), Color);
                    if (steep)
                    {
                        SetPixel(g, (int)yPixel1, (int)xPixel1, c1);
                        SetPixel(g, (int)yPixel1 + 1, (int)xPixel1, c2);
                    }
                    else
                    {
                        SetPixel(g, (int)xPixel1, (int)yPixel1, c1);
                        SetPixel(g, (int)xPixel1, (int)yPixel1 + 1, c2);
                    }
                    double intery = yEnd + gradient;

                    //end point
                    xEnd = round(x1);
                    yEnd = y1 + gradient * (xEnd - x1);
                    xGap = fpart(x1 + 0.5);
                    double xPixel2 = xEnd;
                    double yPixel2 = ipart(yEnd);
                    

                    c1 = Color.FromArgb((int)(rfpart(yEnd) * xGap * 255), Color);
                    c2 = Color.FromArgb((int)(fpart(yEnd) * xGap * 255), Color);
                    if (steep)
                    {
                        SetPixel(g, (int)yPixel2, (int)xPixel2, c1);
                        SetPixel(g, (int)yPixel2 + 1, (int)xPixel2, c2);
                    }
                    else
                    {
                        SetPixel(g, (int)xPixel2, (int)yPixel2, c1);
                        SetPixel(g, (int)xPixel2, (int)yPixel2 + 1, c2);
                    }


                    //between
                    if (steep)
                    {
                        for (int x = (int)(xPixel1 + 1); x <= xPixel2 - 1; x++)
                        {
                            c1 = Color.FromArgb((int)(rfpart(intery) * 255), Color);
                            c2 = Color.FromArgb((int)(fpart(intery) * 255), Color);
                            SetPixel(g, ipart(intery), x, c1);
                            SetPixel(g, ipart(intery) + 1, x, c2);
                            intery += gradient;
                        }
                    }
                    else
                    {
                        for (int x = (int)(xPixel1 + 1); x <= xPixel2 - 1; x++)
                        {
                            c1 = Color.FromArgb((int)(rfpart(intery) * 255), Color);
                            c2 = Color.FromArgb((int)(fpart(intery) * 255), Color);
                            SetPixel(g, x, ipart(intery), c1);
                            SetPixel(g, x, ipart(intery) + 1, c2);
                            intery += gradient;
                        }
                    }
                    break;
            }

        }

        public void Move(Vec2<double> by)
        {
            P1.Move(by);
            P2.Move(by);
        }

        public void Rotate(double angle, Vec2<double> origin)
        {
            P1.Rotate(angle, origin);
            P2.Rotate(angle, origin);
        }

        public void Scale(Vec2<double> by, Vec2<double> origin)
        {
            P1.Scale(by, origin);
            P2.Scale(by, origin);
        }

        private void SetPixel(Graphics g, int x, int y, Color color)
        {
            Brush.Color = color;
            g.FillRectangle(Brush, x, y, 1, 1);
        }
        //help functions
        static private int ipart(double x) { return (int)x; }

        static private int round(double x) { return ipart(x + 0.5); }

        static private double fpart(double x)
        {
            if (x < 0) return 1 - (x - Math.Floor(x));
            return (x - Math.Floor(x));
        }

        static private double rfpart(double x)
        {
            return 1 - fpart(x);
        }

        static private void swap(ref double o1, ref double o2)
        {
            double tmp = o1;
            o1 = o2;
            o2 = tmp;
        }

    }
}
