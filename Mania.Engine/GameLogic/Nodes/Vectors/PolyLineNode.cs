
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Mania.Engine.GameLogic.Components;
using Mania.Engine.GameLogic.Nodes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Vector;

public class PolyLineNode : Node
{
    public GraphicsDevice GraphicsDevice { get; }
    public List<LineNode> LineNodes { get; set; }

    public PolyLineNode(GraphicsDevice graphicsDevice, Vector2[] points, PolyLineNodeOptions? options = null)
    {
        GraphicsDevice = graphicsDevice;
        LineNodes = new List<LineNode>();

        for (int i = 0; i < points.Length - 1; i++)
        {
            LineNodes.Add(new LineNode(graphicsDevice, points[i], points[i + 1]));
        }

        if (options is not null)
        {
            if (options.Closed)
            {
                LineNodes.Add(new LineNode(graphicsDevice, points[points.Length - 1], points[0]));
            }
        }

        Relatives.AddChildren(LineNodes.ToArray());
    }
}


