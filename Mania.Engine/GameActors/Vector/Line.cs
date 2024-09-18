using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameActors.Vector;

public class Line : Dot
{
    public Vector2 EndPosition { get; set; }

    private float rotation;


    public Line(GraphicsDevice graphicsDevice, Vector2 startPosition, Vector2 endPosition, Point width) : base(graphicsDevice, startPosition, width)
    {
        EndPosition = endPosition;
    }

    protected override void Update(GameTime gameTime)
    {
        Vector2 delta = EndPosition - Spatial.Position;
        float length = MathHelper.Distance(delta.X, delta.Y);
        Spatial.Size = new Point(Spatial.Size.X, (int)length);

        rotation = MathF.Sin(length / delta.Y);

    }

    protected override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(PixelUnit, Spatial.Area, null, Color.Red, rotation, Vector2.Zero, SpriteEffects.None, 0.5f);
    }
}