using System.Text.Json.Serialization;

namespace Mania.Library.LDtk.Definitions;

public class EnumTagValueData
{
    [JsonPropertyName("enumValueId")]
    public string EnumValueId { get; set; }

    [JsonPropertyName("tileIds")]
    public long[] TileIds { get; set; }
}
