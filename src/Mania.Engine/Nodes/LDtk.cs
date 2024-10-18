using System.Dynamic;
using System.Linq;
using System.Net.Mime;
using System.Text.Json;
using Mania.Library;
using Mania.Library.LDtk;

namespace Mania.Engine.Nodes.LDtk;
public class LDtk : Node
{
    public LDtkData Data { get; private set;}
    public LDtkWorld? World { get; set; }
    public string JSON => JsonSerializer.Serialize(Data) ?? "{}";
    public override string ToString() => JSON;
    LDtkSettings Settings { get; set;}

    public LDtk(LDtkSettings settings)
    {
        Settings = settings;
    }
    protected override void LoadContent()
    {
        Data = LocalContent.Load<LDtkData>(Settings.Path);
        Relatives.RemoveAllChildren();

        WorldData? worldData = Data.WorldsData.SingleOrDefault(w => w.Identifier == Settings.World);
        if (worldData is null)
        {
            GameDebug.Warning($"Cant find world with name {worldData}. Tries to load first world data instead");
            worldData = Data.WorldsData[0];

            if (worldData is null)
            {
                throw new System.Exception($"Can't find the first world in world data array");
            }
        }

        World = Relatives.AddChild(new LDtkWorld(worldData));
        if (World is null)
        {
            throw new System.Exception($"Can't create world with name {worldData}");
        }


        World.LoadLevel(Settings.Level);
    }

}
