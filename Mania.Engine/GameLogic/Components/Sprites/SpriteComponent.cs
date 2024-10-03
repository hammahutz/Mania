using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Components;

public class SpriteComponent : GfxComponent
{
    private int _currentRow, _currentColumn;
    public Point SpriteSize
    {
        get => (SourceRectangle?.Size) ?? Point.Zero;
        set => SourceRectangle = SourceRectangle is not null ? new Rectangle(SourceRectangle.Value.Location, value) : new Rectangle(Point.Zero, value);
    }
    public Point SpritePosition => new(CurrentRow * SpriteSize.X, CurrentColumn * SpriteSize.Y);

    public int CurrentRow
    {
        get => _currentRow;
        set
        {
            _currentRow = Math.Clamp(value, 0, AtlasRows);
            SourceRectangle = new Rectangle(SpritePosition, SpriteSize);
        }
    }

    public int CurrentColumn
    {
        get => CurrentColumn;
        set => Math.Clamp(value, 0, AtlasColumns);
    }

    public int AtlasRows => SpriteSize.X / Texture2D.Width;
    public int AtlasColumns => SpriteSize.Y / Texture2D.Height;



    public SpriteComponent(Node node, Texture2D texture2D)
        : base(node, texture2D)
    {
        CurrentRow = 0;

        CurrentColumn = 0;
        SourceRectangle = new Rectangle(0, 0, 0, 0);
    }

    public void SetAtlasPosition(int row, int column)
    {
    }
}
