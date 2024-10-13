using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Mania.Engine.GameLogic;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


using MonoLDtk.Shared.LDtkProject.Data;


namespace MonoLDtk.Shared.LDtkProject;
public class LDtkRoot : Node
{
    internal LDtkData LDtkData;
    public LDtkWorld? world { get; set; }
    public string JSON => JsonSerializer.Serialize(LDtkData) ?? "{}";
    public override string ToString() => JSON;


    public LDtkRoot() => LDtkData = new LDtkData();
    public LDtkRoot(string ldtkData) => Load(ldtkData);

    public void Load(string ldtkData) => LDtkData = JsonSerializer.Deserialize<LDtkData>(ldtkData) ?? new LDtkData();

    public void LoadWorld(string name)
    {
        Relatives.RemoveAllChildren();
        world = Relatives.AddChild(new LDtkWorld(LDtkData.WorldsData.Single(w => w.Identifier == name)));
    }

    public void LoadLevel(string name)
    {
        world.Relatives.RemoveAllChildren();
        world.CurrentLevel = name;
    }
}