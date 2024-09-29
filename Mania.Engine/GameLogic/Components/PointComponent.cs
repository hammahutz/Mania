using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Components;

public class PointComponent : SpriteComponent
{
    public PointComponent(Node node, GraphicsDevice graphicsDevice) : base(node, GetPixel(graphicsDevice)) { }

    private static Texture2D GetPixel(GraphicsDevice graphicsDevice)
    {
        Texture2D pixel = new Texture2D(graphicsDevice, 1, 1);
        pixel.SetData([Color.White]);
        return pixel;
    }
}
