using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Mania.Engine.GameLogic.Nodes.LDtk.Data.Definitions;

internal class TilesetDefinitionData
{
    /// <summary>
    /// Grid-based height
    /// </summary>
    [JsonPropertyName("__cHei")]
    internal long CHei { get; set; }

    /// <summary>
    /// Grid-based width
    /// </summary>
    [JsonPropertyName("__cWid")]
    internal long CWid { get; set; }

    /// <summary>
    /// The following data is used internally for various optimizations. It's always synced with
    /// source image changes.
    /// </summary>
    [JsonPropertyName("cachedPixelData")]
    internal Dictionary<string, dynamic> CachedPixelData { get; set; }

    /// <summary>
    /// An array of custom tile metadata
    /// </summary>
    [JsonPropertyName("customData")]
    internal TileCustomMetaData[] CustomData { get; set; }

    /// <summary>
    /// If this value is set, then it means that this atlas uses an internal LDtk atlas image
    /// instead of a loaded one. Possible values: &lt;`null`&gt;, `LdtkIcons`
    /// </summary>
    [JsonPropertyName("embedAtlas")]
    internal EmbedAtlasData? EmbedAtlas { get; set; }

    /// <summary>
    /// Tileset tags using Enum values specified by `tagsSourceEnumId`. This array contains 1
    /// element per Enum value, which contains an array of all Tile IDs that are tagged with it.
    /// </summary>
    [JsonPropertyName("enumTags")]
    internal EnumTagValueData[] EnumTags { get; set; }

    /// <summary>
    /// User defined unique identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    internal string Identifier { get; set; }

    /// <summary>
    /// Distance in pixels from image borders
    /// </summary>
    [JsonPropertyName("padding")]
    internal long Padding { get; set; }

    /// <summary>
    /// Image height in pixels
    /// </summary>
    [JsonPropertyName("pxHei")]
    internal long PxHei { get; set; }

    /// <summary>
    /// Image width in pixels
    /// </summary>
    [JsonPropertyName("pxWid")]
    internal long PxWid { get; set; }

    /// <summary>
    /// Path to the source file, relative to the current project JSON file<br/>  It can be null
    /// if no image was provided, or when using an embed atlas.
    /// </summary>
    [JsonPropertyName("relPath")]
    internal string RelPath { get; set; }

    /// <summary>
    /// Array of group of tiles selections, only meant to be used in the editor
    /// </summary>
    [JsonPropertyName("savedSelections")]
    internal Dictionary<string, dynamic>[] SavedSelections { get; set; }

    /// <summary>
    /// Space in pixels between all tiles
    /// </summary>
    [JsonPropertyName("spacing")]
    internal long Spacing { get; set; }

    /// <summary>
    /// An array of user-defined tags to organize the Tilesets
    /// </summary>
    [JsonPropertyName("tags")]
    internal string[] Tags { get; set; }

    /// <summary>
    /// Optional Enum definition UID used for this tileset meta-data
    /// </summary>
    [JsonPropertyName("tagsSourceEnumUid")]
    internal long? TagsSourceEnumUid { get; set; }

    [JsonPropertyName("tileGridSize")]
    internal long TileGridSize { get; set; }

    /// <summary>
    /// Unique Intidentifier
    /// </summary>
    [JsonPropertyName("uid")]
    internal long Uid { get; set; }
}
