using Mania.Engine.GameLogic.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Nodes.Vectors;

public class PointNode : Node
{
    public VectorComponent VectorComponent { get; private set; }
    public GraphicsDevice GraphicsDevice { get; }

    public PointNode(GraphicsDevice graphicsDevice, Vector2 position)
        : base()
    {
        GraphicsDevice = graphicsDevice;
        Transform.LocalPosition = position;
        VectorComponent = Components.AddToGameLoop(new VectorComponent(this, GraphicsDevice));
    }
}
