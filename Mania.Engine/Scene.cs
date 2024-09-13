using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine;

public abstract class Scene
{
    public event Action<Scene> OnChangeScene;
    public void ChangeScene(Scene scene) => OnChangeScene?.Invoke(scene);
    protected ContentManager GlobalContent { get; private set; }
    protected ContentManager LocalContent { get; private set; }

    public void Enter(Game game)
    {
        GlobalContent = game.Content;
        LocalContent = new ContentManager(game.Services);
        LoadContent();
    }

    protected virtual void LoadContent() { }
    public abstract void Update(GameTime gameTime);
    public abstract void Draw(SpriteBatch spriteBatch);
    protected virtual void UnloadContent() { }

    public void Exit()
    {
        LocalContent.Unload();
        LocalContent.Dispose();
        UnloadContent();
    }
}
