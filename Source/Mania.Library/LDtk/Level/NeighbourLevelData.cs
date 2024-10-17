using System;
using System.Text.Json.Serialization;

namespace Mania.Library.LDtk.Level;

public class NeighbourLevelData
{
    /// <summary>
    /// A single lowercase character tipping on the level location (`n`orth, `s`outh, `w`est,
    /// `e`ast).
    /// </summary>
    [JsonPropertyName("dir")]
    public string Dir { get; set; }

    /// <summary>
    /// Neighbour Instance Identifier
    /// </summary>
    [JsonPropertyName("levelIid")]
    public Guid LevelIid { get; set; }

    /// <summary>
    /// **WARNING**: this deprecated value is no longer exported since version 1.2.0  Replaced
    /// by: `levelIid`
    /// </summary>
    [JsonPropertyName("levelUid")]
    public long? LevelUid { get; set; }
}
