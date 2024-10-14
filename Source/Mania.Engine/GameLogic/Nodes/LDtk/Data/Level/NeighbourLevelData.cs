using System;
using System.Text.Json.Serialization;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkLevel;

internal class NeighbourLevelData
{
    /// <summary>
    /// A single lowercase character tipping on the level location (`n`orth, `s`outh, `w`est,
    /// `e`ast).
    /// </summary>
    [JsonPropertyName("dir")]
    internal string Dir { get; set; }

    /// <summary>
    /// Neighbour Instance Identifier
    /// </summary>
    [JsonPropertyName("levelIid")]
    internal Guid LevelIid { get; set; }

    /// <summary>
    /// **WARNING**: this deprecated value is no longer exported since version 1.2.0  Replaced
    /// by: `levelIid`
    /// </summary>
    [JsonPropertyName("levelUid")]
    internal long? LevelUid { get; set; }
}
