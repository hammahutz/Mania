using Mania.Engine.GameLogic.Components;
using Mania.Engine.GameLogic.Nodes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Vector;

public class PointNode : Node
{
    public PointComponent PointComponent { get; private set; }
    public GraphicsDevice GraphicsDevice { get; }

    public PointNode(GraphicsDevice graphicsDevice, Vector2 position)
        : base()
    {
        GraphicsDevice = graphicsDevice;
        Transform.LocalPosition = position;
        PointComponent = new PointComponent(this, GraphicsDevice);
        Components.AddToGameLoop(PointComponent);
    }
}
