using SFML.Graphics;
using SFML.System;

namespace GK_rysowanie_odcinków
{
    class OriginPointer : Drawable
    {
        public Vector2f Position { get; set; }

        public OriginPointer(float x, float y)
        {
            Position = new Vector2f(x, y);
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            RectangleShape r = new RectangleShape(new Vector2f(5, 5)) {
                Position = Position,
                FillColor = Color.Yellow,
                OutlineColor = Color.Red,
                OutlineThickness = 1,
                Origin =new Vector2f(3,3)
            };
            target.Draw(r, states);
            r.Dispose();
        }
    }
}
