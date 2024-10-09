using Mania.Engine.GameLogic.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Nodes.Vectors;

public class LineNode : Node
{
    public GraphicsDevice GraphicsDevice { get; }
    public LineComponent LineComponent { get; set; }
    public LineNode(GraphicsDevice graphicsDevice, Vector2 start, Vector2 end)
    {
        GraphicsDevice = graphicsDevice;
        Transform.LocalPosition = start;

        LineComponent = Components.AddToGameLoop(new LineComponent(this, GraphicsDevice)
        {
            EndPosition = end
        });


    }
}

