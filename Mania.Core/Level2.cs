using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mania.Core.Data.Pipeline.Json;
using Mania.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mania.Core;

public class Level2 : Scene
{
    private SpriteFont _debugFont;

    public GraphicsDevice GraphicsDevice { get; private set; }

    public Level2(GraphicsDevice graphicsDevice) => GraphicsDevice = graphicsDevice;
    protected override void LoadContent()
    {
        _debugFont = GlobalContent.Load<SpriteFont>(ContentPaths.SpriteFont.Debug);
    }

    public override void UpdateScene(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.Space))
            ChangeScene(new Level1(GraphicsDevice));
    }

    public override void DrawScene(SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(_debugFont, "Hello from Level2", new Vector2(100, 100), Color.Red);
    }

    protected override void UnloadContent()
    {
    }
}
