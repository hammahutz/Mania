using Mania.Engine.GameLogic.Components;
using Mania.Engine.Nodes;
using Microsoft.Xna.Framework;

namespace Mania.Engine.Nodes.UI;

public class UIText : Node
{
    public TextComponent Text { get; private set; }
    public UIText(string spriteFontPath)
    {
        Relatives.RemoveParent();
        Text = Components.AddToGameLoop(new TextComponent(this, spriteFontPath));
        Transform.LocalPosition = new Vector2(100, 100);
    }
}
