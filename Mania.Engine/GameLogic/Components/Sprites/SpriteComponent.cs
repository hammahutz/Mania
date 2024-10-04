using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Components;

public class SpriteComponent : GfxComponent
{
    public Point Size { get; private set; }
    public Point Location => new(CurrentRow * Size.X, CurrentColumn * Size.Y);

    public int CurrentRow { get; private set; } = 0;
    public int CurrentColumn { get; private set; } = 0;

    public int Rows => Size.X / Texture2D.Width;
    public int Columns => Size.Y / Texture2D.Height;

    public SpriteComponent(Node node, Texture2D texture2D, Point spriteSize)
        : base(node, texture2D)
    {
        SetLocation(Point.Zero);
        SetSize(spriteSize);
    }

    public void SetLocation(Point location)
    {
        CurrentRow = Math.Clamp(location.X, 0, Rows);
        CurrentColumn = Math.Clamp(location.Y, 0, Columns);
        SourceRectangle = new Rectangle(Location, Size);
    }

    public void SetSize(Point size)
    {
        Size = size;
        SourceRectangle = new Rectangle(Location, Size);
    }
}
