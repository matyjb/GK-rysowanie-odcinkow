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
                    x += (P2.X - P1.X != 0) ? 1/m : 0;
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
