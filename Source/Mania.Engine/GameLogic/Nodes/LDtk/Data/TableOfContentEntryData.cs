using System.Text.Json.Serialization;

namespace Mania.Engine.GameLogic.Nodes.LDtk.Data;

internal class TableOfContentEntryData
{
    [JsonPropertyName("identifier")]
    internal string Identifier { get; set; }

    [JsonPropertyName("instances")]
    internal ReferenceToAnEntityInstanceData[] Instances { get; set; }
}
