using Mania.Engine.GameLogic.Nodes.LDtk.Data.Level;
using System;
using System.Text.Json.Serialization;

namespace Mania.Engine.GameLogic.Nodes.LDtk.Data;

internal class WorldData
{
    /// <summary>
    /// User defined unique identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    internal string Identifier { get; set; }

    /// <summary>
    /// Unique instance identifer
    /// </summary>
    [JsonPropertyName("iid")]
    internal Guid Iid { get; set; }

    /// <summary>
    /// All levels from this world. The order of this array is only relevant in
    /// `LinearHorizontal` and `linearVertical` world layouts (see `worldLayout` value).
    /// Otherwise, you should refer to the `worldX`,`worldY` coordinates of each Level.
    /// </summary>
    [JsonPropertyName("levels")]
    internal LevelData[] Levels { get; set; }

    /// <summary>
    /// Default new level height
    /// </summary>
    [JsonPropertyName("defaultLevelHeight")]
    internal long DefaultLevelHeight { get; set; }

    /// <summary>
    /// Default new level width
    /// </summary>
    [JsonPropertyName("defaultLevelWidth")]
    internal long DefaultLevelWidth { get; set; }

    /// <summary>
    /// Height of the world grid in pixels.
    /// </summary>
    [JsonPropertyName("worldGridHeight")]
    internal long WorldGridHeight { get; set; }

    /// <summary>
    /// Width of the world grid in pixels.
    /// </summary>
    [JsonPropertyName("worldGridWidth")]
    internal long WorldGridWidth { get; set; }

    /// <summary>
    /// An enum that describes how levels are organized in this project (ie. linearly or in a 2D
    /// space). Possible values: `Free`, `GridVania`, `LinearHorizontal`, `LinearVertical`, `null`
    /// </summary>
    [JsonPropertyName("worldLayout")]
    internal WorldLayout? WorldLayout { get; set; }
}
