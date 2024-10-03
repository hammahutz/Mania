using System;
using Mania.Engine.Util;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Components;

public class LineComponent : GfxComponent
{
    private Vector2 _endPosition;

    public LineComponent(Node node, GraphicsDevice graphicsDevice) : base(node, TextureHelper.GetPixel(graphicsDevice)) { }

    public Vector2 EndPosition
    {
        get => _endPosition;
        set
        {
            _endPosition = value;

            Vector2 delta = EndPosition - Node.Transform.Position;
            SetLength(delta);
            SetRotation(delta);
        }
    }

    private void SetRotation(Vector2 delta)
    {
        Vector2 size = new((int)Node.Transform.LocalScale.X, (int)delta.Length());
        Node.Transform.LocalScale = size;
    }

    private void SetLength(Vector2 delta)
    {
        Node.Transform.LocalRotation = MathF.Atan(delta.Y / delta.X);
        Node.Transform.LocalRotation += delta.X < 0 ? MathF.PI / 2 : -MathF.PI / 2;
    }
}