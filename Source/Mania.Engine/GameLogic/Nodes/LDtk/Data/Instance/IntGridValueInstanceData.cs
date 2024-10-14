using System.Text.Json.Serialization;

namespace Mania.Engine.GameLogic.Nodes.LDtk.Data.Instance;

internal class IntGridValueInstanceData
{
    /// <summary>
    /// Coordinate ID in the layer grid
    /// </summary>
    [JsonPropertyName("coordId")]
    internal long CoordId { get; set; }

    /// <summary>
    /// IntGrid value
    /// </summary>
    [JsonPropertyName("v")]
    internal long V { get; set; }
}
