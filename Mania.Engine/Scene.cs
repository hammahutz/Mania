using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine;

public abstract class Scene : State
{
    protected Game Game {get; private set;}
    protected ContentManager GlobalContent { get; private set; }
    protected ContentManager LocalContent { get; private set; }
    public Scene(Game game)
    {
        Game = game;
    }

    public override void Enter()
    {
        GlobalContent = Game.Content;
        LocalContent = new ContentManager(Game.Services);
        LoadContent();
    }

    protected virtual void LoadContent() { }
    public abstract void Update(GameTime gameTime);
    public abstract void Draw(SpriteBatch spriteBatch);
    protected virtual void UnloadContent() { }

    public override void Exit()
    {
        LocalContent.Unload();
        LocalContent.Dispose();
        UnloadContent();
    }
}
