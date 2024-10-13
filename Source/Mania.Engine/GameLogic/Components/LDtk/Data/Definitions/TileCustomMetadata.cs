using System.Text.Json.Serialization;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkDefinitions;

internal class TileCustomMetaData
{
    [JsonPropertyName("data")]
    internal string Data { get; set; }

    [JsonPropertyName("tileId")]
    internal long TileId { get; set; }
}
