using System;
using System.Linq;
using Mania.Library.LDtk.Instance;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Engine.Nodes.LDtk;

public class LDtkLayer : Node
{
    public LayerInstanceData Data { get; }

    internal LDtkLayer(LayerInstanceData layerInstance)
    {
        Data = layerInstance;

        Relatives.AddChildren
        (
            layerInstance.AutoLayerTiles
                .Select(t => new LDtkTile(t, FormatRelativePath(Data.TilesetRelPath), (int)layerInstance.GridSize))
                .ToArray()
        );
    }

    private string FormatRelativePath(string relPath)
    {
        int textureIndex = relPath.IndexOf("Texture");
        int filetypeIndex = relPath.LastIndexOf(".");

        return relPath.Substring(textureIndex, filetypeIndex - textureIndex);
    }
}