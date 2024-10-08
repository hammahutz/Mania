using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Nodes.Vectors;

public class RectangleNode : Node
{
    public GraphicsDevice GraphicsDevice { get; }
    public LineNode[] LineNodes { get; private set; }
    public PointNode? Fill { get; private set; }
    public Point Size { get; set; }

    public RectangleNode(GraphicsDevice graphicsDevice, Vector2 size, RectangleNodeOptions? options = null)
    {
        GraphicsDevice = graphicsDevice;

        var northWest = Transform.Position;
        var northEast = new Vector2(Transform.Position.X + size.X, Transform.Position.Y);
        var southEast = new Vector2(Transform.Position.X + size.X, Transform.Position.Y + size.Y);
        var southWest = new Vector2(Transform.Position.X, Transform.Position.Y + size.Y);


        LineNodes = [
            new LineNode(graphicsDevice, northWest, northEast),
            new LineNode(graphicsDevice, northEast, southEast),
            new LineNode(graphicsDevice, southEast, southWest),
        ];

        if (options is not null)
        {
            if (options.Closed)
            {
                LineNodes = [.. LineNodes, new LineNode(graphicsDevice, southWest, northWest)];
            }
            if (options.Fill)
            {
                Fill = new PointNode(graphicsDevice, Vector2.Zero);
                Fill.Transform.LocalScale = size;
                Fill.PointComponent.Color = Color.Blue;
            }
        }

        Relatives.AddChildren(LineNodes);
        Relatives.AddChild(Fill);
    }
}


