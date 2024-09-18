using System;
using System.Collections.Generic;
using Mania.Engine.GameActors;
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

    protected List<Actor> Actors { get; set; }

    public void Enter(Game game)
    {
        GlobalContent = game.Content;
        LocalContent = new ContentManager(game.Services);
        LocalContent.RootDirectory = "Content";
        Actors = new List<Actor>();
        LoadContent();
    }

    protected abstract void LoadContent();
    public void Update(GameTime gameTime)
    {
        Actors.ForEach(a => a.UpdateActor(gameTime));
        UpdateScene(gameTime);
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        Actors.ForEach(a => a.DrawActor(spriteBatch));
        DrawScene(spriteBatch);
    }
    public virtual void UpdateScene(GameTime gameTime) { }
    public virtual void DrawScene(SpriteBatch spriteBatch) { }
    protected abstract void UnloadContent();

    public void Exit()
    {
        LocalContent.Unload();
        LocalContent.Dispose();
        Actors.ForEach(a => a = null);
        UnloadContent();
    }
}
