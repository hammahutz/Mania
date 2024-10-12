using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Components;

public sealed class GfxComponent : Component, IDraw, ILoadContent
{
    private string _texturePath;
    public Texture2D Texture2D { get; private set; }
    public Rectangle? SourceRectangle { get; set; } = null;
    public Color Color { get; set; } = Color.White;
    public Vector2 Origin { get; set; } = Vector2.Zero;
    public SpriteEffects Effects { get; set; } = SpriteEffects.None;
    public float LayerDepth { get; set; } = 0.5f;

    public GfxComponent(Node node, string texturePath) : base(node) => _texturePath = texturePath;

    public void Load(ContentManager contentManager)
    {
        Texture2D = contentManager.Load<Texture2D>(_texturePath);
        Origin = Texture2D.Bounds.Center.ToVector2();
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw
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

}
