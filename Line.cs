using System;
using System.Drawing;

namespace GK_rysowanie_odcinków
{
    class Line : Transformable<double>, Drawable
    {
        public Vec2d P1 { get; set; }
        public Vec2d P2 { get; set; }

        public Line(Vec2d p1, Vec2d p2)
        {
            P1 = p1;
            P2 = p2;
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
                            g.FillRectangle(Brushes.Black, (int)Math.Round(x), Convert.ToInt32(y), 1, 1); //SetPixel
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
                            g.FillRectangle(Brushes.Black, Convert.ToInt32(x), (int)Math.Round(y), 1, 1); //SetPixel
                            y += m;
                        }
                    }
                    break;
                case LineDrawingAlgorithms.Wu:
                    //help functions
                    int ipart(double x) { return (int)x; }

                    int round(double x) { return ipart(x + 0.5); }

                    double fpart(double x)
                    {
                        if (x < 0) return 1 - (x - Math.Floor(x));
                        return (x - Math.Floor(x));
                    }

                    double rfpart(double x)
                    {
                        return 1 - fpart(x);
                    }

                    void swap(ref double o1, ref double o2)
                    {
                        double tmp = o1;
                        o1 = o2;
                        o2 = tmp;
                    }

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


                    double xEnd = round(x0);
                    double yEnd = y0 + gradient * (xEnd - x0);
                    double xGap = rfpart(x0 + 0.5);
                    double xPixel1 = xEnd;
                    double yPixel1 = ipart(yEnd);

                    if (steep)
                    {
                        g.FillRectangle(Brushes.Black, (int)yPixel1, (int)xPixel1, 1, 1);
                        g.FillRectangle(Brushes.Black, (int)yPixel1 + 1, (int)xPixel1, 1, 1);
                        //plot(bitmap, yPixel1, xPixel1, rfpart(yEnd) * xGap);
                        //plot(bitmap, yPixel1 + 1, xPixel1, fpart(yEnd) * xGap);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.Black, (int)xPixel1, (int)yPixel1, 1, 1);
                        g.FillRectangle(Brushes.Black, (int)xPixel1, (int)yPixel1 + 1, 1, 1);
                        //plot(bitmap, xPixel1, yPixel1, rfpart(yEnd) * xGap);
                        //plot(bitmap, xPixel1, yPixel1 + 1, fpart(yEnd) * xGap);
                    }
                    double intery = yEnd + gradient;

                    xEnd = round(x1);
                    yEnd = y1 + gradient * (xEnd - x1);
                    xGap = fpart(x1 + 0.5);
                    double xPixel2 = xEnd;
                    double yPixel2 = ipart(yEnd);
                    if (steep)
                    {
                        g.FillRectangle(Brushes.Black, (int)yPixel2, (int)xPixel2, 1, 1);
                        g.FillRectangle(Brushes.Black, (int)yPixel2 + 1, (int)xPixel2, 1, 1);
                        //plot(bitmap, yPixel2, xPixel2, rfpart(yEnd) * xGap);
                        //plot(bitmap, yPixel2 + 1, xPixel2, fpart(yEnd) * xGap);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.Black, (int)xPixel2, (int)yPixel2, 1, 1);
                        g.FillRectangle(Brushes.Black, (int)xPixel2, (int)yPixel2 + 1, 1, 1);
                        //plot(bitmap, xPixel2, yPixel2, rfpart(yEnd) * xGap);
                        //plot(bitmap, xPixel2, yPixel2 + 1, fpart(yEnd) * xGap);
                    }

                    if (steep)
                    {
                        for (int x = (int)(xPixel1 + 1); x <= xPixel2 - 1; x++)
                        {
                            g.FillRectangle(Brushes.Black, ipart(intery), x, 1, 1);
                            g.FillRectangle(Brushes.Black, ipart(intery) + 1, x, 1, 1);
                            //plot(bitmap, ipart(intery), x, rfpart(intery));
                            //plot(bitmap, ipart(intery) + 1, x, fpart(intery));
                            intery += gradient;
                        }
                    }
                    else
                    {
                        for (int x = (int)(xPixel1 + 1); x <= xPixel2 - 1; x++)
                        {
                            g.FillRectangle(Brushes.Black, x, ipart(intery), 1, 1);
                            g.FillRectangle(Brushes.Black, x, ipart(intery) + 1, 1, 1);
                            //plot(bitmap, x, ipart(intery), rfpart(intery));
                            //plot(bitmap, x, ipart(intery) + 1, fpart(intery));
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
    }
}
