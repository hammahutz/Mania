using System.Text.Json.Serialization;

namespace MonoLDtk.Shared.LDtkProject.Data;

internal class TableOfContentEntryData
{
    [JsonPropertyName("identifier")]
    internal string Identifier { get; set; }

    [JsonPropertyName("instances")]
    internal ReferenceToAnEntityInstanceData[] Instances { get; set; }
}
