using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mania.Core;

public class MainGame : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private SpriteFont _debugFont;

    public MainGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        _debugFont = Content.Load<SpriteFont>("Debug");

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        _spriteBatch.Begin();
#if DIRECTX
        _spriteBatch.DrawString(_debugFont, "Hello world, DirectX", Vector2.Zero, Color.GreenYellow);
#endif
#if OPENGL
        _spriteBatch.DrawString(_debugFont, "Hello world, OpenGL", Vector2.Zero, Color.Blue);
#endif
#if ANDROID
        _spriteBatch.DrawString(_debugFont, "Hello world, DirectX", Vector2.Zero, Color.Green);
#endif
        // #else
        //         _spriteBatch.DrawString(_debugFont, "Hello world, from the void!?", Vector2.Zero, Color.Purple);
        // #endif
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
