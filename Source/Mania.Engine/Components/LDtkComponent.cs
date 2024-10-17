using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mania.Engine.GameLogic;
using Mania.Engine.Nodes;
using Mania.Library.LDtk;
using Microsoft.Xna.Framework.Content;

namespace Mania.Engine.Components;

public class LDtkComponent : Component, ILoadContent
{

    public string Path { get; private set; }
    public LDtkData Data { get; private set; }

    public LDtkComponent(Node node, string path) : base(node) => Path = path;

    public void LoadContent(ContentManager contentManager) => Data = contentManager.Load<LDtkData>(Path);
}
