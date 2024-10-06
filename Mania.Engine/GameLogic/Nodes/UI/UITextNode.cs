using Mania.Engine.GameLogic.Components.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.GameLogic.Nodes.UI;

public class UITextNode : Node
{
    public UIText UIText { get; private set; }
    public UITextNode(SpriteFont spriteFont)
    {
        UIText = Components.AddToGameLoop(new UIText(this, spriteFont));
        Transform.LocalPosition = new Vector2(100,100);
    }
}
