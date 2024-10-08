using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Components;

public class TextComponent : Component, IDrawComponent
{
    public SpriteFont SpriteFont { get; set; }
    public string Content { get; set; } = "";
    public Color Color { get; set; } = Color.White;
    public Vector2 Origin { get; set; } = Vector2.Zero;
    public SpriteEffects Effects { get; set; } = SpriteEffects.None;
    public float LayerDepth { get; set; } = 0.5f;

    public TextComponent(Node node, SpriteFont spriteFont) : base(node) => SpriteFont = spriteFont;

    public virtual void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString
        (
            SpriteFont,
            Content,
            Node.Transform.Position,
            Color,
            Node.Transform.Rotation,
            Origin,
            Node.Transform.Scale,
            Effects,
            LayerDepth
        );
    }
}
