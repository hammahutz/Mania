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

public class Level1 : Scene
{
    private SpriteFont _debugFont;
    private ExampleModel _exampleModel;

    protected override void LoadContent()
    {
        _debugFont = GlobalContent.Load<SpriteFont>("Debug");
        _exampleModel = LocalContent.Load<ExampleModel>("example");
    }

    public override void Update(GameTime gameTime)
    {
         if (Keyboard.GetState().IsKeyDown(Keys.Space))
            ChangeScene(new Level2());
    }

    public override void Draw(SpriteBatch spriteBatch)
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

        spriteBatch.DrawString(_debugFont, $"Hello world from {platform}", Vector2.Zero, Color.GreenYellow);
        spriteBatch.DrawString(_debugFont, _exampleModel.ToString(), new Vector2(0, 20f), Color.Green);
        spriteBatch.DrawString(_debugFont, "Hello from Level1", new Vector2(100, 100), Color.Red);
    }

    protected override void UnloadContent()
    {
        _exampleModel = null;
    }
}
