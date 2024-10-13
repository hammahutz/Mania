using MonoLDtk.Shared.LDtkProject.Data.LDtkTileset;

using System.Text.Json.Serialization;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkDefinitions;

internal class IntGridValueDefinitionData
{
    [JsonPropertyName("color")]
    internal string Color { get; set; }

    /// <summary>
    /// User defined unique identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    internal string Identifier { get; set; }

    [JsonPropertyName("tile")]
    internal TilesetRectangleData Tile { get; set; }

    /// <summary>
    /// The IntGrid value itself
    /// </summary>
    [JsonPropertyName("value")]
    internal long Value { get; set; }
}
