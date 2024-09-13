using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine;

public class SceneDirector
{
    public Game Game { get; set; }
    protected Scene CurrentScene { get; set; }
    public SceneDirector(Game game, Scene scene)
    {
        Game = game;
        TransitionToScene(scene);
    }

    public void Update(GameTime gameTime) => CurrentScene.Update(gameTime);
    public void Draw(SpriteBatch spriteBatch) => CurrentScene.Draw(spriteBatch);
    public void TransitionToScene(Scene nextScene)
    {
        UnloadCurrentScene();
        LoadNextScene(nextScene);
    }
    private void LoadNextScene(Scene nextScene)
    {
        CurrentScene = nextScene;
        CurrentScene.OnChangeScene += TransitionToScene;
        CurrentScene.Enter(Game);
    }
    private void UnloadCurrentScene()
    {
        if (CurrentScene != null)
        {
            CurrentScene.Exit();
            CurrentScene.OnChangeScene -= TransitionToScene;
        }
    }

}
