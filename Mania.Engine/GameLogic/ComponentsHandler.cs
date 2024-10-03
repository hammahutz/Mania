using System;
using Mania.Engine.GameLogic.Components;
using Mania.Engine.Util;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic;

public class ComponentsHandler
{
    public Node CurrentNode { get; private set; }

    public ComponentsHandler(Node node)
    {
        CurrentNode = node;
    }

    public event Action<GameTime> OnUpdate;
    public event Action<SpriteBatch> OnDraw;

    public ComponentsHandler AddToGameLoop(Component component)
    {
        if (component is IDrawComponent)
        {
            OnDraw += ((IDrawComponent)component).Draw;
        }
        else if (component is IUpdateComponent)
        {
            OnUpdate += ((IUpdateComponent)component).Update;
        }
        else
        {
            GameDebug.Warning($"Not a compatible component {component}");
        }
        return this;
    }

    public ComponentsHandler RemoveFromGameLoop(Component component)
    {
        if (component is IDrawComponent)
        {
            OnDraw -= ((IDrawComponent)component).Draw;
        }
        else if (component is IUpdateComponent)
        {
            OnUpdate -= ((IUpdateComponent)component).Update;
        }
        else
        {
            GameDebug.Warning($"Not a compatible component {component}");
        }
        component.Depose();
        return this;
    }

    public void Update(GameTime gameTime) => OnUpdate?.Invoke(gameTime);

    public void Draw(SpriteBatch spriteBatch) => OnDraw?.Invoke(spriteBatch);

    public void Depose()
    {
        OnDraw = null;
        OnUpdate = null;
    }
}
