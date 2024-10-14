using System.Text.Json.Serialization;

namespace Mania.Engine.GameLogic.Nodes.LDtk.Data.Definitions;

internal class EnumTagValueData
{
    [JsonPropertyName("enumValueId")]
    internal string EnumValueId { get; set; }

    [JsonPropertyName("tileIds")]
    internal long[] TileIds { get; set; }
}
