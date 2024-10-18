
using System.Collections.Generic;
using Mania.Engine.Nodes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.Nodes.Vectors;

public class VectorPolyLine : Node
{
    public GraphicsDevice GraphicsDevice { get; }
    public List<VectorLine> LineNodes { get; set; }

    public VectorPolyLine(GraphicsDevice graphicsDevice, Vector2[] points, VectorPolyLineOptions? options = null)
    {
        GraphicsDevice = graphicsDevice;
        LineNodes = new List<VectorLine>();

        for (int i = 0; i < points.Length - 1; i++)
        {
            LineNodes.Add(new VectorLine(graphicsDevice, points[i], points[i + 1]));
        }

        if (options is not null)
        {
            if (options.Closed)
            {
                LineNodes.Add(new VectorLine(graphicsDevice, points[points.Length - 1], points[0]));
            }
        }

        Relatives.AddChildren(LineNodes.ToArray());
    }
}


