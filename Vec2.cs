using System;
namespace GK_rysowanie_odcinków
{
    public class Vec2d : ITransformableVec2d
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vec2d() : this(0, 0) { }
        public Vec2d(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Move(Vec2d by)
        {
            X = by.X + X;
            Y = by.Y + Y;
        }

        public void Rotate(double angle, Vec2d origin)
        {
            Move(-origin);
            double xp = X * Math.Cos(angle) - Y * Math.Sin(angle);
            double yp = X * Math.Sin(angle) + Y * Math.Cos(angle);
            X = xp;
            Y = yp;
            Move(origin);
        }
        public void Rotate(double angle)
        {
            Rotate(angle, new Vec2d(0, 0));
        }

        public void Scale(Vec2d by, Vec2d origin)
        {
            Move(-origin);
            X = (X * by.X);
            Y = (Y * by.Y);
            Move(origin);
        }

        public void Scale(Vec2d by)
        {
            Scale(by, new Vec2d(0, 0));
        }

        public static Vec2d operator +(Vec2d l, Vec2d r)
        {
            return new Vec2d(l.X + r.X, l.Y + r.Y);
        }

        public static Vec2d operator -(Vec2d l, Vec2d r)
        {
            return new Vec2d(l.X - r.X, l.Y - r.Y);
        }

        public static Vec2d operator -(Vec2d r)
        {
            return new Vec2d(-r.X, -r.Y);
        }
    }
}
