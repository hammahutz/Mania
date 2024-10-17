using System.Text.Json.Serialization;

namespace Mania.Library.LDtk.Instance;

public class IntGridValueInstanceData
{
    /// <summary>
    /// Coordinate ID in the layer grid
    /// </summary>
    [JsonPropertyName("coordId")]
    public long CoordId { get; set; }

    /// <summary>
    /// IntGrid value
    /// </summary>
    [JsonPropertyName("v")]
    public long V { get; set; }
}
