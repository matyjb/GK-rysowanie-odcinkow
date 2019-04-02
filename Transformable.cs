using SFML.System;

namespace GK_rysowanie_odcinków
{
    interface ITransformable
    {
        void Rotate(double angle, Vector2f origin);
        void Scale(Vector2f by, Vector2f origin);
        void Move(Vector2f by);
    }
}
