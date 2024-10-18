using Mania.Library.LDtk.Tileset;
using System.Text.Json.Serialization;

namespace Mania.Library.LDtk.Definitions;

public class EnumValueDefinitionData
{
    /// <summary>
    /// **WARNING**: this deprecated value will be *removed* completely on version 1.4.0+
    /// Replaced by: `tileRect`
    /// </summary>
    [JsonPropertyName("__tileSrcRect")]
    public long[] TileSrcRect { get; set; }

    /// <summary>
    /// Optional color
    /// </summary>
    [JsonPropertyName("color")]
    public long Color { get; set; }

    /// <summary>
    /// Enum value
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// **WARNING**: this deprecated value will be *removed* completely on version 1.4.0+
    /// Replaced by: `tileRect`
    /// </summary>
    [JsonPropertyName("tileId")]
    public long? TileId { get; set; }

    /// <summary>
    /// Optional tileset rectangle to represents this value
    /// </summary>
    [JsonPropertyName("tileRect")]
    public TilesetRectangleData TileRect { get; set; }
}
