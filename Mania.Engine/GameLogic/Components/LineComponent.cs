using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Components;

public class LineComponent : PointComponent
{
    private Vector2 endPosition;

    public LineComponent(Node node, GraphicsDevice graphicsDevice) : base(node, graphicsDevice)
    {
    }

    public Vector2 EndPosition
    {
        get => endPosition;
        set
        {
            endPosition = value;

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