using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic;

public abstract class Node
{
    public event Action<Node> OnChangeScene;

    public void ChangeScene(Node scene) => OnChangeScene?.Invoke(scene);

    public ContentManager GlobalContent { get; private set; }
    public ContentManager LocalContent { get; private set; }

    public Transform Transform { get; private set; }
    public RelativeHandler Relatives { get; private set; }
    public ComponentHandler Components { get; private set; }

    public Node()
    {
        Transform = new Transform(this);

        Relatives = new RelativeHandler(this);
        Components = new ComponentHandler(this);
    }

    public void Enter(ContentManager globalContent, ContentManager localContent)
    {
        GlobalContent = globalContent;
        LocalContent = localContent;

        LoadContent();
    }

    protected virtual void LoadContent() { }

    public void Update(GameTime gameTime)
    {
        UpdateNode(gameTime);
        Components.Update(gameTime);
        Relatives.Children.ForEach(c => c.Update(gameTime));
    }

    protected virtual void UpdateNode(GameTime gameTime) { }

    public void Draw(SpriteBatch spriteBatch)
    {
        DrawNode(spriteBatch);
        Components.Draw(spriteBatch);
        Relatives.Children.ForEach(c => c.Draw(spriteBatch));
    }

    protected virtual void DrawNode(SpriteBatch spriteBatch) { }

    public void Depose()
    {
        Relatives.Depose();
        Components.Depose();
        Relatives = null;
        Components = null;
    }

    public void Exit()
    {
        LocalContent.Unload();
        LocalContent.Dispose();
        Depose();
    }
}
