using Mania.Engine.GameLogic.Components;
using Mania.Engine.Nodes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.Nodes.Vectors;

public class VectorPoint : Node
{
    public VectorComponent VectorComponent { get; private set; }
    public GraphicsDevice GraphicsDevice { get; }

    public VectorPoint(GraphicsDevice graphicsDevice, Vector2 position)
        : base()
    {
        GraphicsDevice = graphicsDevice;
        Transform.LocalPosition = position;
        VectorComponent = Components.AddToGameLoop(new VectorComponent(this, GraphicsDevice));
    }
}
