using Mania.Engine.GameLogic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mania.Core;

public class Level2 : Node
{
    private SpriteFont _debugFont;

    public GraphicsDevice GraphicsDevice { get; private set; }

    public Level2(GraphicsDevice graphicsDevice) => GraphicsDevice = graphicsDevice;


    protected override void LoadContent()
    {
        _debugFont = GlobalContent.Load<SpriteFont>(ContentPaths.SpriteFont.Debug);
    }

    protected override void UpdateNode(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.Space))
            ChangeScene(new Level1(GraphicsDevice));
    }

    protected override void DrawNode(SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(_debugFont, "Hello from Level2", new Vector2(100, 100), Color.Red);
    }

}
