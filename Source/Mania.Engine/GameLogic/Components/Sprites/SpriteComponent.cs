using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Components;

public class SpriteComponent : GfxComponent
{
    public Point CellCoordinate { get; private set; }
    public Point CellSize { get; private set; }
    public Rectangle CellSource => new Rectangle(CellCoordinate, CellSize);

    public int CurrentRow { get; private set; }
    public int CurrentColumn { get; private set; }

    public int Rows => CellSize.X / Texture2D.Width;
    public int Columns => CellSize.Y / Texture2D.Height;


    public SpriteComponent(Node node, Texture2D texture2D, Point location, Point size)
        : base(node, texture2D)
    {
        SetCellSize(size);
        SetCellLocation(location);
    }

    public void SetCellLocation(Point cell) => SetCellLocation(cell.X, cell.Y);
    public void SetCellLocation(int column, int row)
    {
        CurrentColumn = Math.Clamp(column, 0, Columns);
        CurrentRow = Math.Clamp(row, 0, Rows);

        CellCoordinate = new Point(CurrentColumn * CellSize.X, CurrentRow * CellSize.Y);
        SourceRectangle = CellSource;
    }

    public void SetCellSize(Point size)
    {
        CellSize = size;
        SetCellLocation(CurrentColumn, CurrentRow);
    }
}
