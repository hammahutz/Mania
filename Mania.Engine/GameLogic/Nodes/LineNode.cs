using Mania.Engine.GameLogic.Components;
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

        LineComponent = new LineComponent(this, GraphicsDevice);
        LineComponent.EndPosition = end;

        Components.AddToGameLoop(LineComponent);
    }
}

