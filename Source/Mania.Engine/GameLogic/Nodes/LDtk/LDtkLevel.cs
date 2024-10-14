using System;
using System.Linq;
using Mania.Engine.GameLogic;
using Mania.Engine.GameLogic.Nodes.LDtk.Data.Level;
using Microsoft.Xna.Framework;
using MonoLDtk.Shared.LDtkProject;

namespace Mania.Engine.GameLogic.Nodes.LDtk;

internal class LDtkLevel : Node
{
    internal string Identifier { get; private set; }
    internal Guid Iid { get; private set; }
    internal Vector2 WorldPosition;
    public long WorldDepth { get; private set; }


    internal LDtkLevel(LevelData level)
    {
        Identifier = level.Identifier;
        Iid = level.Iid;
        WorldDepth = level.WorldDepth;

        Transform.LocalPosition = new Vector2(level.WorldX, level.WorldY);

        Relatives.AddChildren
        (
            level.LayerInstances
            .Select(li => new LDtkLayer(li))
            .ToArray()
        );
    }
}
