using Mania.Core.Data.Pipeline.Json;
using Mania.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mania.Core;

public class MainGame : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private SpriteFont _debugFont;
    private ExampleModel _exampleModel;
    private SceneDirector<Scene> _sceneDirector;

    public MainGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        _debugFont = Content.Load<SpriteFont>(AssetPath.FontsDebug);
        _exampleModel = Content.Load<ExampleModel>("example");
        _sceneDirector = new SceneDirector<Scene>(this, new Level1(this));
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        base.Update(gameTime);
        _sceneDirector.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();

        _sceneDirector.Draw(_spriteBatch);

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
        _spriteBatch.DrawString(_debugFont, $"Hello world from {platform}", Vector2.Zero, Color.GreenYellow);
        _spriteBatch.DrawString(_debugFont, _exampleModel.ToString(), new Vector2(0, 20f), Color.Green);

        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
