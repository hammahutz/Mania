using System;
using System.Linq;
using Mania.Engine.Nodes;
using Mania.Library.LDtk;
using Mania.Library.LDtk.Level;

namespace Mania.Engine.Nodes.LDtk;

public class LDtkWorld : Node
{
    public WorldData Data { get; private set; }
    public LDtkWorld(WorldData worldData) => Data = worldData;
    public LDtkLevel? Level {get; set;}
    public void LoadLevel(string name)
    {
        Relatives.RemoveAllChildren();

        LevelData? levelData = Data.Levels.SingleOrDefault(l => l.Identifier == name);
        levelData ??= Data.Levels[0];

        Level = Relatives.AddChild(new LDtkLevel(levelData));

        if (Level is null)
        {
            throw new Exception($"Can't create world with name {levelData}");
        }

    }
}
