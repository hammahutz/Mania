using Mania.Engine.GameLogic;
using Mania.Engine.GameLogic.Nodes.UI;
using Microsoft.VisualBasic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mania.Core;

public class Level2 : Node
{

    public GraphicsDevice GraphicsDevice { get; private set; }

    public Level2(GraphicsDevice graphicsDevice) => GraphicsDevice = graphicsDevice;


    protected override void LoadContent()
    {
        var text = Relatives.AddChild(new TextNode(ContentPaths.SpriteFont.Debug));
        text.Text.Content = "Hello from level 2";
    }

    protected override void UpdateNode(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.Space))
            ChangeScene(new Level1(GraphicsDevice));
    }

    protected override void DrawNode(SpriteBatch spriteBatch)
    {
    }

}
