using System.Text.Json.Serialization;

namespace Mania.Engine.GameLogic.Nodes.LDtk.Data.Definitions;

internal class AutoLayerRuleDefinitionData
{
    /// <summary>
    /// If FALSE, the rule effect isn't applied, and no tiles are generated.
    /// </summary>
    [JsonPropertyName("active")]
    internal bool Active { get; set; }

    [JsonPropertyName("alpha")]
    internal double Alpha { get; set; }

    /// <summary>
    /// When TRUE, the rule will prevent other rules to be applied in the same cell if it matches
    /// (TRUE by default).
    /// </summary>
    [JsonPropertyName("breakOnMatch")]
    internal bool BreakOnMatch { get; set; }

    /// <summary>
    /// Chances for this rule to be applied (0 to 1)
    /// </summary>
    [JsonPropertyName("chance")]
    internal double Chance { get; set; }

    /// <summary>
    /// Checker mode Possible values: `None`, `Horizontal`, `Vertical`
    /// </summary>
    [JsonPropertyName("checker")]
    internal CheckerData Checker { get; set; }

    /// <summary>
    /// If TRUE, allow rule to be matched by flipping its pattern horizontally
    /// </summary>
    [JsonPropertyName("flipX")]
    internal bool FlipX { get; set; }

    /// <summary>
    /// If TRUE, allow rule to be matched by flipping its pattern vertically
    /// </summary>
    [JsonPropertyName("flipY")]
    internal bool FlipY { get; set; }

    /// <summary>
    /// Default IntGrid value when checking cells outside of level bounds
    /// </summary>
    [JsonPropertyName("outOfBoundsValue")]
    internal long? OutOfBoundsValue { get; set; }

    /// <summary>
    /// Rule pattern (size x size)
    /// </summary>
    [JsonPropertyName("pattern")]
    internal long[] Pattern { get; set; }

    /// <summary>
    /// If TRUE, enable Perlin filtering to only apply rule on specific random area
    /// </summary>
    [JsonPropertyName("perlinActive")]
    internal bool PerlinActive { get; set; }

    [JsonPropertyName("perlinOctaves")]
    internal double PerlinOctaves { get; set; }

    [JsonPropertyName("perlinScale")]
    internal double PerlinScale { get; set; }

    [JsonPropertyName("perlinSeed")]
    internal double PerlinSeed { get; set; }

    /// <summary>
    /// X pivot of a tile stamp (0-1)
    /// </summary>
    [JsonPropertyName("pivotX")]
    internal double PivotX { get; set; }

    /// <summary>
    /// Y pivot of a tile stamp (0-1)
    /// </summary>
    [JsonPropertyName("pivotY")]
    internal double PivotY { get; set; }

    /// <summary>
    /// Pattern width & height. Should only be 1,3,5 or 7.
    /// </summary>
    [JsonPropertyName("size")]
    internal long Size { get; set; }

    /// <summary>
    /// Array of all the tile IDs. They are used randomly or as stamps, based on `tileMode` value.
    /// </summary>
    [JsonPropertyName("tileIds")]
    internal long[] TileIds { get; set; }

    /// <summary>
    /// Defines how tileIds array is used Possible values: `Single`, `Stamp`
    /// </summary>
    [JsonPropertyName("tileMode")]
    internal TileModeData TileMode { get; set; }

    /// <summary>
    /// Max random offset for X tile pos
    /// </summary>
    [JsonPropertyName("tileRandomXMax")]
    internal long TileRandomXMax { get; set; }

    /// <summary>
    /// Min random offset for X tile pos
    /// </summary>
    [JsonPropertyName("tileRandomXMin")]
    internal long TileRandomXMin { get; set; }

    /// <summary>
    /// Max random offset for Y tile pos
    /// </summary>
    [JsonPropertyName("tileRandomYMax")]
    internal long TileRandomYMax { get; set; }

    /// <summary>
    /// Min random offset for Y tile pos
    /// </summary>
    [JsonPropertyName("tileRandomYMin")]
    internal long TileRandomYMin { get; set; }

    /// <summary>
    /// Tile X offset
    /// </summary>
    [JsonPropertyName("tileXOffset")]
    internal long TileXOffset { get; set; }

    /// <summary>
    /// Tile Y offset
    /// </summary>
    [JsonPropertyName("tileYOffset")]
    internal long TileYOffset { get; set; }

    /// <summary>
    /// Unique Int identifier
    /// </summary>
    [JsonPropertyName("uid")]
    internal long Uid { get; set; }

    /// <summary>
    /// X cell coord modulo
    /// </summary>
    [JsonPropertyName("xModulo")]
    internal long XModulo { get; set; }

    /// <summary>
    /// X cell start offset
    /// </summary>
    [JsonPropertyName("xOffset")]
    internal long XOffset { get; set; }

    /// <summary>
    /// Y cell coord modulo
    /// </summary>
    [JsonPropertyName("yModulo")]
    internal long YModulo { get; set; }

    /// <summary>
    /// Y cell start offset
    /// </summary>
    [JsonPropertyName("yOffset")]
    internal long YOffset { get; set; }
}
