using System.Text.Json.Serialization;

namespace Mania.Engine.GameLogic.Nodes.LDtk.Data.Definitions;

internal class TileCustomMetaData
{
    [JsonPropertyName("data")]
    internal string Data { get; set; }

    [JsonPropertyName("tileId")]
    internal long TileId { get; set; }
}
