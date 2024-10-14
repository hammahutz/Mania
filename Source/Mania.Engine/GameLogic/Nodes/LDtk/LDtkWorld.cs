
using System;
using System.Collections.Generic;
using System.Linq;
using Mania.Engine.GameLogic;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoLDtk.Shared.LDtkProject.Data;

namespace MonoLDtk.Shared.LDtkProject;

public class LDtkWorld : Node
{
    internal string Identifier { get; private set; }
    internal Guid Iid { get; private set; }

    internal List<LDtkLevel> Levels { get; private set; }
    internal int CurrentLevel { get; private set; } = 0;

    internal LDtkWorld(WorldData worldData)
    {
        Identifier = worldData.Identifier;
        Iid = worldData.Iid;

        Relatives.AddChildren
        (
            worldData.Levels
            .Select(l => new LDtkLevel(l))
            .OrderBy(l => l.WorldDepth)
            .ToArray()
        );
    }
}
