namespace GK_rysowanie_odcinków
{
    interface Transformable<T>
    {
        void Rotate(double angle, Vec2<T> origin);
        void Scale(Vec2<double> by, Vec2<T> origin);
        void Move(Vec2<T> by);
    }
}
