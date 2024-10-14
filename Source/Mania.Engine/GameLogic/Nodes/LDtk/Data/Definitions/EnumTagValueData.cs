using System.Text.Json.Serialization;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkDefinitions;

internal class EnumTagValueData
{
    [JsonPropertyName("enumValueId")]
    internal string EnumValueId { get; set; }

    [JsonPropertyName("tileIds")]
    internal long[] TileIds { get; set; }
}
