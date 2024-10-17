using System.Linq;
using System.Text.Json;
using Mania.Library.LDtk;

namespace Mania.Engine.Nodes.LDtk;
public class LDtk : Node
{
    public LDtkData Data { get; }
    public LDtkWorld? World { get; set; }
    public string JSON => JsonSerializer.Serialize(Data) ?? "{}";
    public override string ToString() => JSON;

    public LDtk(string ldtkPath, string worldName, string levelName)
    {
        Data = LocalContent.Load<LDtkData>(ldtkPath);
        LoadWorld(worldName, levelName);
    }

    public void LoadWorld(string worldName, string levelName)
    {
        Relatives.RemoveAllChildren();

        WorldData? worldData = Data.WorldsData.SingleOrDefault(w => w.Identifier == worldName);
        worldData ??= Data.WorldsData[0];

        World = Relatives.AddChild(new LDtkWorld(worldData));

        if (World is null)
        {
            throw new System.Exception($"Can't create world with name {worldData}");
        }


        World.LoadLevel(levelName);
    }
}