using System.Security.Cryptography.X509Certificates;
using Mania.Engine.GameLogic.Components;
using Mania.Engine.Nodes;
using Mania.Library.LDtk.Instance;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.Nodes.LDtk;

public class LDtkTile : Node
{
    public TileInstanceData Data { get; }
    public GfxComponent GFX { get; private set; }

    public LDtkTile(TileInstanceData tileInstance, string texturePath, int tileSize)
    {
        Data = tileInstance;

        Transform.LocalPosition = new Vector2(tileInstance.Px[0], tileInstance.Px[1]);
        Transform.LocalScale = new Vector2(tileSize);


        GFX = Components.AddToGameLoop
        (
            new GfxComponent(this, texturePath)
                .SetSourceRectangle(new Rectangle((int)tileInstance.Src[0], (int)tileInstance.Src[1], tileSize, tileSize))
                .SetEffects((SpriteEffects)(int)tileInstance.F)
                .SetAlphaColor((float)tileInstance.A)
                .SetColor(Color.CornflowerBlue)
        );
    }

}
