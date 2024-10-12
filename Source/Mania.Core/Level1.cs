using Mania.Engine.GameLogic;
using Mania.Engine.GameLogic.Nodes.UI;
using Mania.Engine.GameLogic.Nodes.Vectors;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mania.Core;
public class Level1 : Node
{
    public GraphicsDevice GraphicsDevice { get; private set; }
    private TextNode _debugText;
    private Point mousePos = Point.Zero;
    private LineNode LineNode;

    public Level1(GraphicsDevice graphicsDevice) => GraphicsDevice = graphicsDevice;

    protected override void LoadContent()
    {
        _debugText = Relatives.AddChild(new TextNode(ContentPaths.SpriteFont.Debug));
        LineNode = Relatives.AddChild(new LineNode(GraphicsDevice, new Vector2(0, 0), new Vector2(400, 600)));

        var PointNode = new PointNode(GraphicsDevice, new Vector2(100, 100));
        PointNode.Transform.LocalScale = new Vector2(100, 100);
        PointNode.VectorComponent.Color = Color.Magenta;
        Relatives.AddChild(PointNode);

        Relatives.AddChild(new PolyLineNode(
            GraphicsDevice,
            [
                new Vector2(0,0),
                new Vector2(100,50),
                new Vector2(500,600),
            ],
            new PolyLineNodeOptions() { Closed = true }
        ));

        Relatives.AddChild(
                new RectangleNode(GraphicsDevice, new Vector2(100, 100), new RectangleNodeOptions { Closed = true, Fill = false })
        );
    }

    protected override void UpdateNode(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.Space))
            ChangeScene(new Level2(GraphicsDevice));

        if (Keyboard.GetState().IsKeyDown(Keys.Left))
            Transform.LocalPosition += 10 * Vector2.UnitX * (float)gameTime.ElapsedGameTime.TotalSeconds;

        mousePos = Mouse.GetState().Position;
        LineNode.LineComponent.EndPosition = mousePos.ToVector2();
    }

    protected override void DrawNode(SpriteBatch spriteBatch)
    {
        string platform;
#if DIRECTX
        platform = "DirectX";
#elif OPENGL
        platform = "OpenGL";
#elif ANDROID
        platform = "Android";
#else
        platform = "the void!?";
#endif

        _debugText.Text.Content =
            @$"Hello world from {platform}
            Hello form level 1
            {mousePos}";
    }
}
