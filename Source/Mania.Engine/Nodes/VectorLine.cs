using Mania.Engine.GameLogic.Components;
using Mania.Engine.Nodes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.Nodes.Vectors;

public class VectorLine : Node
{
    public GraphicsDevice GraphicsDevice { get; }
    public VectorLineComponent LineComponent { get; set; }
    public VectorLine(GraphicsDevice graphicsDevice, Vector2 start, Vector2 end)
    {
        GraphicsDevice = graphicsDevice;
        Transform.LocalPosition = start;

        LineComponent = Components.AddToGameLoop(new VectorLineComponent(this, GraphicsDevice)
        {
            EndPosition = end
        });
    }
}
