using MonoLDtk.Shared.LDtkProject.Data.LDtkTileset;

using System.Text.Json.Serialization;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkDefinitions;

internal class EntityDefinitionData
{

    /// <summary>
    /// Base entity color
    /// </summary>
    [JsonPropertyName("color")]
    internal string Color { get; set; }

    /// <summary>
    /// User defined documentation for this element to provide help/tips to level designers.
    /// </summary>
    [JsonPropertyName("doc")]
    internal string Doc { get; set; }

    /// <summary>
    /// If enabled, all instances of this entity will be listed in the project "Table of content"
    /// object.
    /// </summary>
    [JsonPropertyName("exportToToc")]
    internal bool ExportToToc { get; set; }

    /// <summary>
    /// Array of field definitions
    /// </summary>
    [JsonPropertyName("fieldDefs")]
    internal FieldDefinitionData[] FieldDefs { get; set; }

    [JsonPropertyName("fillOpacity")]
    internal double FillOpacity { get; set; }

    /// <summary>
    /// Pixel height
    /// </summary>
    [JsonPropertyName("height")]
    internal long Height { get; set; }

    [JsonPropertyName("hollow")]
    internal bool Hollow { get; set; }

    /// <summary>
    /// User defined unique identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    internal string Identifier { get; set; }

    /// <summary>
    /// Only applies to entities resizable on both X/Y. If TRUE, the entity instance width/height
    /// will keep the same aspect ratio as the definition.
    /// </summary>
    [JsonPropertyName("keepAspectRatio")]
    internal bool KeepAspectRatio { get; set; }

    /// <summary>
    /// Possible values: `DiscardOldOnes`, `PreventAdding`, `MoveLastOne`
    /// </summary>
    [JsonPropertyName("limitBehavior")]
    internal LimitBehavior LimitBehavior { get; set; }

    /// <summary>
    /// If TRUE, the maxCount is a "per world" limit, if FALSE, it's a "per level". Possible
    /// values: `PerLayer`, `PerLevel`, `PerWorld`
    /// </summary>
    [JsonPropertyName("limitScope")]
    internal LimitScope LimitScope { get; set; }

    [JsonPropertyName("lineOpacity")]
    internal double LineOpacity { get; set; }

    /// <summary>
    /// Max instances count
    /// </summary>
    [JsonPropertyName("maxCount")]
    internal long MaxCount { get; set; }

    /// <summary>
    /// Max pixel height (only applies if the entity is resizable on Y)
    /// </summary>
    [JsonPropertyName("maxHeight")]
    internal long? MaxHeight { get; set; }

    /// <summary>
    /// Max pixel width (only applies if the entity is resizable on X)
    /// </summary>
    [JsonPropertyName("maxWidth")]
    internal long? MaxWidth { get; set; }

    /// <summary>
    /// Min pixel height (only applies if the entity is resizable on Y)
    /// </summary>
    [JsonPropertyName("minHeight")]
    internal long? MinHeight { get; set; }

    /// <summary>
    /// Min pixel width (only applies if the entity is resizable on X)
    /// </summary>
    [JsonPropertyName("minWidth")]
    internal long? MinWidth { get; set; }

    /// <summary>
    /// An array of 4 dimensions for the up/right/down/left borders (in this order) when using
    /// 9-slice mode for `tileRenderMode`.<br/>  If the tileRenderMode is not NineSlice, then
    /// this array is empty.<br/>  See: https://en.wikipedia.org/wiki/9-slice_scaling
    /// </summary>
    [JsonPropertyName("nineSliceBorders")]
    internal long[] NineSliceBorders { get; set; }

    /// <summary>
    /// Pivot X coordinate (from 0 to 1.0)
    /// </summary>
    [JsonPropertyName("pivotX")]
    internal double PivotX { get; set; }

    /// <summary>
    /// Pivot Y coordinate (from 0 to 1.0)
    /// </summary>
    [JsonPropertyName("pivotY")]
    internal double PivotY { get; set; }

    /// <summary>
    /// Possible values: `Rectangle`, `Ellipse`, `Tile`, `Cross`
    /// </summary>
    [JsonPropertyName("renderMode")]
    internal RenderMode RenderMode { get; set; }

    /// <summary>
    /// If TRUE, the entity instances will be resizable horizontally
    /// </summary>
    [JsonPropertyName("resizableX")]
    internal bool ResizableX { get; set; }

    /// <summary>
    /// If TRUE, the entity instances will be resizable vertically
    /// </summary>
    [JsonPropertyName("resizableY")]
    internal bool ResizableY { get; set; }

    /// <summary>
    /// Display entity name in editor
    /// </summary>
    [JsonPropertyName("showName")]
    internal bool ShowName { get; set; }

    /// <summary>
    /// An array of strings that classifies this entity
    /// </summary>
    [JsonPropertyName("tags")]
    internal string[] Tags { get; set; }

    /// <summary>
    /// **WARNING**: this deprecated value is no longer exported since version 1.2.0  Replaced
    /// by: `tileRect`
    /// </summary>
    [JsonPropertyName("tileId")]
    internal long? TileId { get; set; }

    [JsonPropertyName("tileOpacity")]
    internal double TileOpacity { get; set; }

    /// <summary>
    /// An object representing a rectangle from an existing Tileset
    /// </summary>
    [JsonPropertyName("tileRect")]
    internal TilesetRectangleData TileRect { get; set; }

    /// <summary>
    /// An enum describing how the the Entity tile is rendered inside the Entity bounds. Possible
    /// values: `Cover`, `FitInside`, `Repeat`, `Stretch`, `FullSizeCropped`,
    /// `FullSizeUncropped`, `NineSlice`
    /// </summary>
    [JsonPropertyName("tileRenderMode")]
    internal TileRenderMode TileRenderMode { get; set; }

    /// <summary>
    /// Tileset ID used for optional tile display
    /// </summary>
    [JsonPropertyName("tilesetId")]
    internal long? TilesetId { get; set; }

    /// <summary>
    /// Unique Int identifier
    /// </summary>
    [JsonPropertyName("uid")]
    internal long Uid { get; set; }

    /// <summary>
    /// Pixel width
    /// </summary>
    [JsonPropertyName("width")]
    internal long Width { get; set; }
}
