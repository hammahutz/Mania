using Mania.Engine.GameActors.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameActors.Vector;

public class Dot : Actor
{
    public Texture2D PixelUnit { get; set; }

    public Dot(GraphicsDevice graphicsDevice, Vector2 position, Point size)
    {

        PixelUnit = new Texture2D(graphicsDevice, 1, 1);
        PixelUnit.SetData([Color.White]);

        Spatial.Position = position;
        Spatial.Size = size;
    }

    protected override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(PixelUnit, Spatial.Area, Color.White);
    }
}
