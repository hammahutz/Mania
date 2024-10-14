using MonoLDtk.Shared.LDtkProject.Data.LDtkTileset;

using System.Text.Json.Serialization;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkDefinitions;

internal class EnumValueDefinitionData
{
    /// <summary>
    /// **WARNING**: this deprecated value will be *removed* completely on version 1.4.0+
    /// Replaced by: `tileRect`
    /// </summary>
    [JsonPropertyName("__tileSrcRect")]
    internal long[] TileSrcRect { get; set; }

    /// <summary>
    /// Optional color
    /// </summary>
    [JsonPropertyName("color")]
    internal long Color { get; set; }

    /// <summary>
    /// Enum value
    /// </summary>
    [JsonPropertyName("id")]
    internal string Id { get; set; }

    /// <summary>
    /// **WARNING**: this deprecated value will be *removed* completely on version 1.4.0+
    /// Replaced by: `tileRect`
    /// </summary>
    [JsonPropertyName("tileId")]
    internal long? TileId { get; set; }

    /// <summary>
    /// Optional tileset rectangle to represents this value
    /// </summary>
    [JsonPropertyName("tileRect")]
    internal TilesetRectangleData TileRect { get; set; }
}
