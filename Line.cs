using System;
using System.Drawing;

namespace GK_rysowanie_odcinków
{
    class Line : Transformable<int>, Drawable
    {
        public Vec2i P1 { get; set; }
        public Vec2i P2 { get; set; }

        public Line(Vec2i p1, Vec2i p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public void Draw(Graphics g)
        {
            float m;
            if (P2.X - P1.X != 0) m = (P2.Y - P1.Y) / (float)(P2.X - P1.X);
            else m = P2.Y - P1.Y;

            if (Math.Abs(m) >= 1)
            {
                Vec2i start = P1.Y < P2.Y ? P1 : P2;
                Vec2i end = P1.Y >= P2.Y ? P1 : P2;

                float x = start.X;
                for (int y = start.Y; y <= end.Y; y++)
                {
                    g.FillRectangle(Brushes.Black, (int)Math.Round(x), y, 1, 1); //SetPixel
                    x += (P2.X - P1.X != 0) ? 1/m : 0;
                }
            }
            else
            {
                Vec2i start = P1.X < P2.X ? P1 : P2;
                Vec2i end = P1.X >= P2.X ? P1 : P2;

                float y = start.Y;
                for (int x = start.X; x <= end.X; x++)
                {
                    g.FillRectangle(Brushes.Black, x, (int)Math.Round(y), 1, 1); //SetPixel
                    y += m;
                }
            }


        }

        public void Move(Vec2<int> by)
        {
            P1.Move(by);
            P2.Move(by);
        }

        public void Rotate(double angle, Vec2<int> origin)
        {
            P1.Rotate(angle, origin);
            P2.Rotate(angle, origin);
        }

        public void Scale(Vec2<int> by, Vec2<int> origin)
        {
            P1.Scale(by, origin);
            P2.Scale(by, origin);
        }
    }
}
