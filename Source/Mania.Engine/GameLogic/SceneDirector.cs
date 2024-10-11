using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic;

public class SceneDirector
{
    public Game Game { get; set; }
    protected Node CurrentScene { get; set; }
    public SceneDirector(Game game, Node scene)
    {
        Game = game;
        TransitionToScene(scene);
    }

    public void Update(GameTime gameTime) => CurrentScene.Update(gameTime);
    public void Draw(SpriteBatch spriteBatch) => CurrentScene.Draw(spriteBatch);
    public void TransitionToScene(Node nextScene)
    {
        UnloadCurrentScene();
        LoadNextScene(nextScene);
    }
    private void LoadNextScene(Node nextScene)
    {
        ContentManager localContent = new ContentManager(Game.Services);
        CurrentScene = nextScene;
        CurrentScene.OnChangeScene += TransitionToScene;
        CurrentScene.Enter(Game.Content, localContent);
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
