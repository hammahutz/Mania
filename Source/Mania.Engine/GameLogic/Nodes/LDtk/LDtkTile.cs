using Mania.Engine.GameLogic;
using Mania.Engine.GameLogic.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.LDtkProject.Data.LDtkInstance;

namespace MonoLDtk.Shared.LDtkProject;

public class LDtkTile : Node
{

    public long Id { get; private set; }

    internal LDtkTile(TileInstanceData tileInstance, string texturePath, int tileSize)
    {
        Id = tileInstance.T;

        Transform.LocalPosition = new Vector2(tileInstance.Px[0], tileInstance.Px[1]);
        Transform.LocalScale = new Vector2(tileSize);


        Components.AddToGameLoop
        (
            new GfxComponent(this, texturePath)
                .SetSourceRectangle(new Rectangle((int)tileInstance.Src[0], (int)tileInstance.Src[1], tileSize, tileSize))
                .SetEffects((SpriteEffects)(int)tileInstance.F)
                .SetAlphaColor((float)tileInstance.A)
                .SetColor(Color.CornflowerBlue)
        );
    }

}
