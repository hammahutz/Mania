using System.Linq;
using Mania.Library;
using Mania.Library.LDtk.Level;
using Microsoft.Xna.Framework;

namespace Mania.Engine.Nodes.LDtk;

public class LDtkLevel : Node
{
    public LevelData Data { get; }
    public LDtkLayer?[] Layers { get; set; }

    public LDtkLevel(LevelData data)
    {
        Data = data;

        Transform.LocalPosition = new Vector2(data.WorldX, data.WorldY);

        if (data.LayerInstances is null)
            GameDebug.Warning($"No layers in level{data.Identifier}");


        Layers = Relatives.AddChildren(data.LayerInstances.Select(li => new LDtkLayer(li))).ToArray();
    }

}
