using System.Text.Json.Serialization;

namespace Mania.Engine.GameLogic.Nodes.LDtk.Data.Definitions;

internal class FieldDefinitionData
{
    /// <summary>
    /// Human readable value type. Possible values: `Int, Float, String, Bool, Color,
    /// ExternEnum.XXX, LocalEnum.XXX, Point, FilePath`.<br/>  If the field is an array, this
    /// field will look like `Array<...>` (eg. `Array<Int>`, `Array<Point>` etc.)<br/>  NOTE: if
    /// you enable the advanced option **Use Multilines type**, you will have "*Multilines*"
    /// instead of "*String*" when relevant.
    /// </summary>
    [JsonPropertyName("__type")]
    internal string Type { get; set; }

    /// <summary>
    /// Optional list of accepted file extensions for FilePath value type. Includes the dot:
    /// `.ext`
    /// </summary>
    [JsonPropertyName("acceptFileTypes")]
    internal string[] AcceptFileTypes { get; set; }

    /// <summary>
    /// Possible values: `Any`, `OnlySame`, `OnlyTags`, `OnlySpecificEntity`
    /// </summary>
    [JsonPropertyName("allowedRefs")]
    internal AllowedRefsData AllowedRefs { get; set; }

    [JsonPropertyName("allowedRefsEntityUid")]
    internal long? AllowedRefsEntityUid { get; set; }

    [JsonPropertyName("allowedRefTags")]
    internal string[] AllowedRefTags { get; set; }

    [JsonPropertyName("allowOutOfLevelRef")]
    internal bool AllowOutOfLevelRef { get; set; }

    /// <summary>
    /// Array max length
    /// </summary>
    [JsonPropertyName("arrayMaxLength")]
    internal long? ArrayMaxLength { get; set; }

    /// <summary>
    /// Array min length
    /// </summary>
    [JsonPropertyName("arrayMinLength")]
    internal long? ArrayMinLength { get; set; }

    [JsonPropertyName("autoChainRef")]
    internal bool AutoChainRef { get; set; }

    /// <summary>
    /// TRUE if the value can be null. For arrays, TRUE means it can contain null values
    /// (exception: array of Points can't have null values).
    /// </summary>
    [JsonPropertyName("canBeNull")]
    internal bool CanBeNull { get; set; }

    /// <summary>
    /// Default value if selected value is null or invalid.
    /// </summary>
    [JsonPropertyName("defaultOverride")]
    internal dynamic DefaultOverride { get; set; }

    /// <summary>
    /// User defined documentation for this field to provide help/tips to level designers about
    /// accepted values.
    /// </summary>
    [JsonPropertyName("doc")]
    internal string Doc { get; set; }

    [JsonPropertyName("editorAlwaysShow")]
    internal bool EditorAlwaysShow { get; set; }

    [JsonPropertyName("editorCutLongValues")]
    internal bool EditorCutLongValues { get; set; }

    /// <summary>
    /// Possible values: `Hidden`, `ValueOnly`, `NameAndValue`, `EntityTile`, `LevelTile`,
    /// `Points`, `PointStar`, `PointPath`, `PointPathLoop`, `RadiusPx`, `RadiusGrid`,
    /// `ArrayCountWithLabel`, `ArrayCountNoLabel`, `RefLinkBetweenPivots`,
    /// `RefLinkBetweenCenters`
    /// </summary>
    [JsonPropertyName("editorDisplayMode")]
    internal EditorDisplayModeData EditorDisplayMode { get; set; }

    /// <summary>
    /// Possible values: `Above`, `Center`, `Beneath`
    /// </summary>
    [JsonPropertyName("editorDisplayPos")]
    internal EditorDisplayPosData EditorDisplayPos { get; set; }

    [JsonPropertyName("editorDisplayScale")]
    internal double EditorDisplayScale { get; set; }

    /// <summary>
    /// Possible values: `ZigZag`, `StraightArrow`, `CurvedArrow`, `ArrowsLine`, `DashedLine`
    /// </summary>
    [JsonPropertyName("editorLinkStyle")]
    internal EditorLinkStyleData EditorLinkStyle { get; set; }

    [JsonPropertyName("editorShowInWorld")]
    internal bool EditorShowInWorld { get; set; }

    [JsonPropertyName("editorTextPrefix")]
    internal string EditorTextPrefix { get; set; }

    [JsonPropertyName("editorTextSuffix")]
    internal string EditorTextSuffix { get; set; }

    /// <summary>
    /// User defined unique identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    internal string Identifier { get; set; }

    /// <summary>
    /// TRUE if the value is an array of multiple values
    /// </summary>
    [JsonPropertyName("isArray")]
    internal bool IsArray { get; set; }

    /// <summary>
    /// Max limit for value, if applicable
    /// </summary>
    [JsonPropertyName("max")]
    internal double? Max { get; set; }

    /// <summary>
    /// Min limit for value, if applicable
    /// </summary>
    [JsonPropertyName("min")]
    internal double? Min { get; set; }

    /// <summary>
    /// Optional regular expression that needs to be matched to accept values. Expected format:
    /// `/some_reg_ex/g`, with optional "i" flag.
    /// </summary>
    [JsonPropertyName("regex")]
    internal string Regex { get; set; }

    [JsonPropertyName("symmetricalRef")]
    internal bool SymmetricalRef { get; set; }

    /// <summary>
    /// Possible values: &lt;`null`&gt;, `LangPython`, `LangRuby`, `LangJS`, `LangLua`, `LangC`,
    /// `LangHaxe`, `LangMarkdown`, `LangJson`, `LangXml`, `LangLog`
    /// </summary>
    [JsonPropertyName("textLanguageMode")]
    internal TextLanguageModeData? TextLanguageMode { get; set; }

    /// <summary>
    /// UID of the tileset used for a Tile
    /// </summary>
    [JsonPropertyName("tilesetUid")]
    internal long? TilesetUid { get; set; }

    /// <summary>
    /// Internal enum representing the possible field types. Possible values: F_Int, F_Float,
    /// F_String, F_Text, F_Bool, F_Color, F_Enum(...), F_Point, F_Path, F_EntityRef, F_Tile
    /// </summary>
    [JsonPropertyName("type")]
    internal string FieldDefinitionType { get; set; }

    /// <summary>
    /// Unique Int identifier
    /// </summary>
    [JsonPropertyName("uid")]
    internal long Uid { get; set; }

    /// <summary>
    /// If TRUE, the color associated with this field will override the Entity or Level default
    /// color in the editor UI. For Enum fields, this would be the color associated to their
    /// values.
    /// </summary>
    [JsonPropertyName("useForSmartColor")]
    internal bool UseForSmartColor { get; set; }
}
