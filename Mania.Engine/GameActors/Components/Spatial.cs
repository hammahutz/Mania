using Microsoft.Xna.Framework;

namespace Mania.Engine.GameActors.Components;

public class Spatial
{
    public Vector2 Position { get; set; } = Vector2.Zero;
    public Vector2 Velocity { get; set; } = Vector2.Zero;
    public Vector2 Acceleration { get; set; } = Vector2.Zero;
    public Point Size { get; set; } = Point.Zero;

    public Rectangle Area { get => new(Position.ToPoint(), Size); }

    public void Update(GameTime gameTime)
    {
        Position += Velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;
        Velocity += Acceleration * (float)gameTime.ElapsedGameTime.TotalSeconds;
    }
}
