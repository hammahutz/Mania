using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Mail;
using Mania.Engine.GameLogic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using MonoLDtk.Shared.LDtkProject.Data.LDtkInstance;

namespace MonoLDtk.Shared.LDtkProject;

public class LDtkLayer : Node
{
    public Guid Iid { get; set; }
    public long? TilesetDefUid { get; set; }
    public string TilesetRelPath { get; set; }
    public string Type { get; set; } = LDtkLayerType.None;
    public Texture2D TileSheet { get; set; }

    internal LDtkLayer(LayerInstanceData layerInstance)
    {
        Iid = layerInstance.Iid;
        TilesetDefUid = layerInstance.TilesetDefUid;
        Type = layerInstance.Type;


        if (layerInstance.TilesetRelPath != null)
        {
            TilesetRelPath = FormatRelativePath(layerInstance.TilesetRelPath) ?? "";
            LoadTiles(layerInstance);
        }
    }

    private void LoadTiles(LayerInstanceData layerInstance)
    {
        Relatives.AddChildren
        (
            layerInstance.AutoLayerTiles
                .Select(t => new LDtkTile(t, TilesetRelPath, (int)layerInstance.GridSize))
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