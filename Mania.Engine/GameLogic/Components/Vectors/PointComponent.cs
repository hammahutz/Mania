using Microsoft.Xna.Framework.Graphics;
using Mania.Engine.Util;

namespace Mania.Engine.GameLogic.Components;

public class PointComponent : GfxComponent
{
    public PointComponent(Node node, GraphicsDevice graphicsDevice) : base(node, TextureHelper.GetPixel(graphicsDevice)) { }
}
