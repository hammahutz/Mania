using System;
using Mania.Engine.Nodes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Components;

public sealed class GfxComponent : Component, IDraw, ILoadContent
{
    private string _texturePath;
    private float _alphaColor = 1.0f;

    public Texture2D Texture2D { get; private set; }
    public Rectangle? SourceRectangle { get; set; } = null;
    public Color Color { get; set; } = Color.White;
    public float AlphaColor
    {
        get => _alphaColor;
        set
        {
            _alphaColor = value;
            Color = new Color(Color, _alphaColor);
        }
    }
    public Vector2 Origin { get; set; } = Vector2.Zero;
    public SpriteEffects Effects { get; set; } = SpriteEffects.None;
    public float LayerDepth { get; set; } = 0.5f;

    #region Builder

    public GfxComponent(Node node, string texturePath) : base(node) => _texturePath = texturePath;

    public GfxComponent SetSourceRectangle(Rectangle rectangle)
    {
        SourceRectangle = rectangle;
        return this;
    }

    public GfxComponent SetColor(Color color)
    {
        Color = color;
        return this;
    }

    public GfxComponent SetAlphaColor(float alphaColor)
    {
        AlphaColor = alphaColor;
        return this;
    }

    public GfxComponent SetOrigin(Vector2 origin)
    {
        Origin = origin;
        return this;
    }

    public GfxComponent SetEffects(SpriteEffects effects)
    {
        Effects = effects;
        return this;
    }

    public GfxComponent SetLayerDepth(float layerDepth)
    {
        LayerDepth = layerDepth;
        return this;
    }
    #endregion


    public void LoadContent(ContentManager contentManager)
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
