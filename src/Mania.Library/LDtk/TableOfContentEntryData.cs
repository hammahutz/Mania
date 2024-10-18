using System.Text.Json.Serialization;

namespace Mania.Library.LDtk;

public class TableOfContentEntryData
{
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    [JsonPropertyName("instances")]
    public ReferenceToAnEntityInstanceData[] Instances { get; set; }
}
