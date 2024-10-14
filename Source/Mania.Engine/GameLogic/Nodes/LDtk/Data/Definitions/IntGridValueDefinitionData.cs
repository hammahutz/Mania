using Mania.Engine.GameLogic.Nodes.LDtk.Data.Tileset;
using System.Text.Json.Serialization;

namespace Mania.Engine.GameLogic.Nodes.LDtk.Data.Definitions;

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
