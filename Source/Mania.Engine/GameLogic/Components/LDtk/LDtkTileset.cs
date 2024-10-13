using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLDtk.Shared.LDtkProject;

public class LDtkTileset
{
    public long Id { get; private set; }
    public Texture2D Texture { get; private set; }

    public LDtkTileset(long id, string relativePath, ContentManager content)
    {
        Id = id;
        if (relativePath != null)
        {
            Texture = content.Load<Texture2D>(FormatRelativePath(relativePath));
        }
    }

    private string FormatRelativePath(string relPath)
    {
        int textureIndex = relPath.IndexOf("Texture");
        int filetypeIndex = relPath.LastIndexOf(".");

        return relPath.Substring(textureIndex, filetypeIndex - textureIndex);
    }

}
