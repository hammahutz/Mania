using System;
using System.Text.Json.Serialization;

namespace Mania.Engine.GameLogic.Nodes.LDtk.Data;

internal class ReferenceToAnEntityInstanceData
{
    /// <summary>
    /// IID of the refered EntityInstance
    /// </summary>
    [JsonPropertyName("entityIid")]
    internal Guid EntityIid { get; set; }

    /// <summary>
    /// IID of the LayerInstance containing the refered EntityInstance
    /// </summary>
    [JsonPropertyName("layerIid")]
    internal Guid LayerIid { get; set; }

    /// <summary>
    /// IID of the Level containing the refered EntityInstance
    /// </summary>
    [JsonPropertyName("levelIid")]
    internal Guid LevelIid { get; set; }

    /// <summary>
    /// IID of the World containing the refered EntityInstance
    /// </summary>
    [JsonPropertyName("worldIid")]
    internal Guid WorldIid { get; set; }
}
