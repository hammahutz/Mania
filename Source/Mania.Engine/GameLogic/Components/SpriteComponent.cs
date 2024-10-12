using System;
using Microsoft.Xna.Framework;

namespace Mania.Engine.GameLogic.Components;

public sealed class SpriteComponent : Component
{
    public GfxComponent Gfx { get; private set; }

    public Point CellCoordinate { get; private set; }
    public Point CellSize { get; private set; }
    public Rectangle CellSource => new Rectangle(CellCoordinate, CellSize);

    public int CurrentRow { get; private set; }
    public int CurrentColumn { get; private set; }

    public int Rows => CellSize.X / Gfx.Texture2D.Width;
    public int Columns => CellSize.Y / Gfx.Texture2D.Height;


    public SpriteComponent(Node node, string texturePath, Point location, Point size)
        : base(node)
    {
        Gfx = Node.Components.AddToGameLoop(new GfxComponent(node, texturePath));
        SetCellSize(size);
        SetCellLocation(location);
    }

    public void SetCellLocation(Point cell) => SetCellLocation(cell.X, cell.Y);
    public void SetCellLocation(int column, int row)
    {
        CurrentColumn = Math.Clamp(column, 0, Columns);
        CurrentRow = Math.Clamp(row, 0, Rows);

        CellCoordinate = new Point(CurrentColumn * CellSize.X, CurrentRow * CellSize.Y);
        Gfx.SourceRectangle = CellSource;
    }

    public void SetCellSize(Point size)
    {
        CellSize = size;
        SetCellLocation(CurrentColumn, CurrentRow);
    }
}
