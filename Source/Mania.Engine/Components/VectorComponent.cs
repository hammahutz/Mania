using Mania.Engine.Nodes;
using Mania.Library;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Components;

public sealed class VectorComponent : Component, IDraw
{
    Texture2D Texture2D { get; set; }
    public Rectangle? SourceRectangle { get; set; } = null;
    public Color Color { get; set; } = Color.White;
    public Vector2 Origin { get; set; } = Vector2.Zero;
    public SpriteEffects Effects { get; set; } = SpriteEffects.None;
    public float LayerDepth { get; set; } = 0.5f;

    public VectorComponent(Node node, GraphicsDevice graphicsDevice) : base(node) => Texture2D = TextureHelper.GetPixel(graphicsDevice);

    public void Draw(SpriteBatch spriteBatch) => spriteBatch.Draw
    (
        Texture2D,
        Node.Transform.Position,
        SourceRectangle,
        Color,
        Node.Transform.Rotation,
        Origin,
        Node.Transform.Scale,
        Effects,
        LayerDepth
    );

}