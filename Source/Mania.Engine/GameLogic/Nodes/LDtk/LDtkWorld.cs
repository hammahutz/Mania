using System;
using System.Linq;
using Mania.Engine.GameLogic.Nodes.LDtk.Data;

namespace Mania.Engine.GameLogic.Nodes.LDtk;

public class LDtkWorld : Node
{
    internal string Identifier { get; private set; }
    internal Guid Iid { get; private set; }

    internal WorldData WorldData { get; private set; }
    internal LDtkLevel? Level { get; private set; }

    internal LDtkWorld(WorldData worldData)
    {
        WorldData = worldData;
        Identifier = worldData.Identifier;
        Iid = worldData.Iid;
    }
    internal void LoadLevel(string name)
    {
        Relatives.RemoveAllChildren();
        Level = Relatives.AddChild(new LDtkLevel(WorldData.Levels.Single(l => l.Identifier == name)));
    }
}
