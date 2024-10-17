using Mania.Engine.Nodes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.Nodes.Vectors;

public class VectorRectangle : Node
{
    public GraphicsDevice GraphicsDevice { get; }
    public VectorLine[] LineNodes { get; private set; }
    public VectorPoint? Fill { get; private set; }
    public Point Size { get; set; }

    public VectorRectangle(GraphicsDevice graphicsDevice, Vector2 size, VectorRectangleOptions? options = null)
    {
        GraphicsDevice = graphicsDevice;

        var northWest = Transform.Position;
        var northEast = new Vector2(Transform.Position.X + size.X, Transform.Position.Y);
        var southEast = new Vector2(Transform.Position.X + size.X, Transform.Position.Y + size.Y);
        var southWest = new Vector2(Transform.Position.X, Transform.Position.Y + size.Y);


        LineNodes = [
            new VectorLine(graphicsDevice, northWest, northEast),
            new VectorLine(graphicsDevice, northEast, southEast),
            new VectorLine(graphicsDevice, southEast, southWest),
        ];

        if (options is not null)
        {
            if (options.Closed)
            {
                LineNodes = [.. LineNodes, new VectorLine(graphicsDevice, southWest, northWest)];
            }
            if (options.Fill)
            {
                Fill = new VectorPoint(graphicsDevice, Vector2.Zero);
                Fill.Transform.LocalScale = size;
                Fill.VectorComponent.Color = Color.Blue;
            }
        }

        Relatives.AddChildren(LineNodes);
        Relatives.AddChild(Fill);
    }
}


