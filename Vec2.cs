using System;
namespace GK_rysowanie_odcinków
{
    public class Vec2<T> : Transformable<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Vec2(T x, T y)
        {
            X = x;
            Y = y;
        }

        public void Move(Vec2<T> by)
        {
            X = (dynamic)by.X + (dynamic)X;
            Y = (dynamic)by.Y + (dynamic)Y;
        }

        public void Rotate(double angle, Vec2<T> origin)
        {
            Move(-origin);
            T xp = X * (dynamic)Math.Cos(angle) - Y * (dynamic)Math.Sin(angle);
            T yp = X * (dynamic)Math.Sin(angle) + Y * (dynamic)Math.Cos(angle);
            X = xp;
            Y = yp;
            Move(origin);
        }
        public void Rotate(double angle)
        {
            Rotate(angle, new Vec2<T>((dynamic)0, (dynamic)0));
        }

        public void Scale(Vec2<T> by, Vec2<T> origin)
        {
            Move(-origin);
            X = (dynamic)X * (dynamic)origin.X;
            Y = (dynamic)Y * (dynamic)origin.Y;
            Move(origin);
        }

        public void Scale(Vec2<T> by)
        {
            Scale(by, new Vec2<T>((dynamic)0, (dynamic)0));
        }

        public static Vec2<T> operator +(Vec2<T> l, Vec2<T> r)
        {
            return new Vec2<T>((dynamic)l.X + r.X, (dynamic)l.Y + r.Y);
        }

        public static Vec2<T> operator -(Vec2<T> l, Vec2<T> r)
        {
            return new Vec2<T>((dynamic)l.X - r.X, (dynamic)l.Y - r.Y);
        }

        public static Vec2<T> operator -(Vec2<T> r)
        {
            return new Vec2<T>(-(dynamic)r.X, -(dynamic)r.Y);
        }
    }
    public class Vec2d : Vec2<double>
    {
        public Vec2d(double x, double y) : base(x, y) { }
        public Vec2d() : base(0,0) { }
    }
    public class Vec2i : Vec2<int>
    {
        public Vec2i(int x, int y) : base(x, y) { }
        public Vec2i() : base(0, 0) { }
    }
}
