using System.Text.Json.Serialization;

namespace Mania.Library.LDtk.Definitions;

public class TileCustomMetaData
{
    [JsonPropertyName("data")]
    public string Data { get; set; }

    [JsonPropertyName("tileId")]
    public long TileId { get; set; }
}
