using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine;

public class SceneDirector<T> : StateDirector<T> where T : Scene
{
    public Game Game { get; set; }

    public SceneDirector(Game game, T scene)
    {
        Game = game;
        CurrentState = scene;
        CurrentState.Enter();
    }

    public void Update(GameTime gameTime) => CurrentState.Update(gameTime);
    public void Draw(SpriteBatch spriteBatch) => CurrentState.Draw(spriteBatch);
}
