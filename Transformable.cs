namespace GK_rysowanie_odcinków
{
    interface ITransformableVec2d
    {
        void Rotate(double angle, Vec2d origin);
        void Scale(Vec2d by, Vec2d origin);
        void Move(Vec2d by);
    }
}
