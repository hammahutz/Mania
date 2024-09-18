using System;
using System.Collections.Generic;
using Mania.Engine.GameActors.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameActors;

public abstract class Actor
{
    public Spatial Spatial { get; set; } = new Spatial();
    public virtual void LoadContent(ContentManager contentManager) { }

    public void UpdateActor(GameTime gameTime)
    {
        Spatial.Update(gameTime);
        Update(gameTime);
    }

    protected virtual void Update(GameTime gameTime) { }

    public void DrawActor(SpriteBatch spriteBatch)
    {
        Draw(spriteBatch);
    }

    protected virtual void Draw(SpriteBatch spriteBatch) { }
}
