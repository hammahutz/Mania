using System;
using Mania.Engine.GameLogic;
using Mania.Engine.Nodes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine;

public class ComponentsHandler
{
    public Node CurrentNode { get; private set; }

    public ComponentsHandler(Node node) => CurrentNode = node;

    public event Action<ContentManager> OnLoad;
    public event Action<GameTime> OnUpdate;
    public event Action<SpriteBatch> OnDraw;

    public T AddToGameLoop<T>(T component) where T : Component
    {
        if (component is ILoadContent)
        {
            OnLoad += ((ILoadContent)component).LoadContent;
        }
        if (component is IUpdate)
        {
            OnUpdate += ((IUpdate)component).Update;
        }
        if (component is IDraw)
        {
            OnDraw += ((IDraw)component).Draw;
        }

        return component;
    }

    public void RemoveFromGameLoop(Component component)
    {
        if (component is ILoadContent)
        {
            OnLoad -= ((ILoadContent)component).LoadContent;
        }
        if (component is IUpdate)
        {
            OnUpdate -= ((IUpdate)component).Update;
        }
        if (component is IDraw)
        {
            OnDraw -= ((IDraw)component).Draw;
        }

        component.Depose();
    }

    public void Load(ContentManager contentManager) => OnLoad?.Invoke(contentManager);

    public void Update(GameTime gameTime) => OnUpdate?.Invoke(gameTime);

    public void Draw(SpriteBatch spriteBatch) => OnDraw?.Invoke(spriteBatch);

    public void Depose()
    {
        OnLoad = null;
        OnDraw = null;
        OnUpdate = null;
    }
}
