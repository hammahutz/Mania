using Mania.Library.LDtk.Tileset;
using System.Text.Json.Serialization;

namespace Mania.Library.LDtk.Definitions;

public class IntGridValueDefinitionData
{
    [JsonPropertyName("color")]
    public string Color { get; set; }

    /// <summary>
    /// User defined unique identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    [JsonPropertyName("tile")]
    public TilesetRectangleData Tile { get; set; }

    /// <summary>
    /// The IntGrid value itself
    /// </summary>
    [JsonPropertyName("value")]
    public long Value { get; set; }
}
