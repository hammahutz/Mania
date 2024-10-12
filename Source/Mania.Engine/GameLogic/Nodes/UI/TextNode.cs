using Mania.Engine.GameLogic.Components;
using Microsoft.Xna.Framework;

namespace Mania.Engine.GameLogic.Nodes.UI;

public class TextNode : Node
{
    public TextComponent Text { get; private set; }
    public TextNode(string spriteFontPath)
    {
        Text = Components.AddToGameLoop(new TextComponent(this, spriteFontPath));
        Transform.LocalPosition = new Vector2(100, 100);
        Text.Content = "Text";
    }
}
