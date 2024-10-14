using System.ComponentModel;
using System.Linq;
using System.Text.Json;
using Mania.Engine.GameLogic;
using Mania.Engine.GameLogic.Nodes.LDtk.Data;
using Mania.Engine.Util;


namespace Mania.Engine.GameLogic.Nodes.LDtk;
public class LDtkNode : Node
{
    internal LDtkData? LDtkData;
    private LDtkWorld? _world;
    public string JSON => JsonSerializer.Serialize(LDtkData) ?? "{}";
    public override string ToString() => JSON;

    public LDtkNode() => LDtkData = new LDtkData();
    public LDtkNode(string ldtkData) => Load(ldtkData);

    public void Load(string ldtkData)
    {
        try
        {
            if (ldtkData.IsNullOrEmpty())
            {
                throw new System.Exception("LDtk data string is null or empty");
            }

            LDtkData = JsonSerializer.Deserialize<LDtkData>(ldtkData);
        }
        catch (System.Exception e)
        {
            GameDebug.Warning($"Tries to load LDtk data but failed: {e}");
        }
    }

    public void LoadWorld(string name)
    {
        if (LDtkData == null)
        {
            GameDebug.Warning($"Tries to load level, but LDtkData is null");
            return;
        }

        Relatives.RemoveAllChildren();
        _world = Relatives.AddChild(new LDtkWorld(LDtkData.WorldsData.Single(w => w.Identifier == name)));
    }

    public void LoadWorld(string name, string levelName)
    {
        if (LDtkData == null)
            return;

        Relatives.RemoveAllChildren();
        _world = Relatives.AddChild(new LDtkWorld(LDtkData.WorldsData.Single(w => w.Identifier == name)));
        _world?.LoadLevel(levelName);
    }
    public void LoadLevel(string name) => _world?.LoadLevel(name);
}