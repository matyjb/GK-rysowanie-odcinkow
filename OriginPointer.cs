using System;
using System.Drawing;

namespace GK_rysowanie_odcinków
{
    class OriginPointer : Drawable
    {
        public Vec2d Position { get; set; }

        public OriginPointer(double x, double y)
        {
            Position = new Vec2d(x, y);
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Red, Convert.ToInt32(Position.X)-1, Convert.ToInt32(Position.Y)-1, 3, 3);
            g.FillRectangle(Brushes.Orange, Convert.ToInt32(Position.X), Convert.ToInt32(Position.Y), 1, 1);
            g.FillRectangle(Brushes.Red, Convert.ToInt32(Position.X), Convert.ToInt32(Position.Y)-2, 1, 1);
            g.FillRectangle(Brushes.Red, Convert.ToInt32(Position.X), Convert.ToInt32(Position.Y)+2, 1, 1);
            g.FillRectangle(Brushes.Red, Convert.ToInt32(Position.X)-2, Convert.ToInt32(Position.Y), 1, 1);
            g.FillRectangle(Brushes.Red, Convert.ToInt32(Position.X)+2, Convert.ToInt32(Position.Y), 1, 1);
        }
    }
}
