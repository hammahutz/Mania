using Mania.Engine.GameLogic.Components;
using Mania.Engine.GameLogic.Nodes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Vector;

public class LineNode : Node
{
    public GraphicsDevice GraphicsDevice { get; }
    public LineComponent LineComponent { get; set; }

    public LineNode(GraphicsDevice graphicsDevice, Vector2 start, Vector2 end)
    {
        GraphicsDevice = graphicsDevice;
        Transform.LocalPosition = start;

        LineComponent =  Components.AddToGameLoop(new LineComponent(this, GraphicsDevice)
        {
            EndPosition = end
        });


    }
}

