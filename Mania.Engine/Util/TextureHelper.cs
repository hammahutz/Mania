using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.Util;

public static class TextureHelper
{
    public static Texture2D GetPixel(GraphicsDevice graphicsDevice)
    {
        Texture2D pixel = new Texture2D(graphicsDevice, 1, 1);
        pixel.SetData([Color.White]);
        return pixel;
    }
}