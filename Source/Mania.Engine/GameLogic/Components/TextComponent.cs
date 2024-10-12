using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Components;

public sealed class TextComponent : Component, IDraw, ILoadContent
{
    private string _spriteFontPath;
    public SpriteFont SpriteFont { get; set; }
    public string Content { get; set; } = "";
    public Color Color { get; set; } = Color.White;
    public Vector2 Origin { get; set; } = Vector2.Zero;
    public SpriteEffects Effects { get; set; } = SpriteEffects.None;
    public float LayerDepth { get; set; } = 0.5f;

    public TextComponent(Node node, string spriteFontPath) : base(node) => _spriteFontPath = spriteFontPath;

    public void Load(ContentManager contentManager) => SpriteFont = contentManager.Load<SpriteFont>($"{_spriteFontPath}");

    public void Draw(SpriteBatch spriteBatch) =>
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
