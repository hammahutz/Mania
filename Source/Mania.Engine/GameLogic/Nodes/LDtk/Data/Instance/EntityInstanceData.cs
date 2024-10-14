using Mania.Engine.GameLogic.Nodes.LDtk.Data.Tileset;
using System;
using System.Text.Json.Serialization;

namespace Mania.Engine.GameLogic.Nodes.LDtk.Data.Instance;

internal class EntityInstanceData
{
    /// <summary>
    /// Grid-based coordinates (`[x,y]` format)
    /// </summary>
    [JsonPropertyName("__grid")]
    internal long[] Grid { get; set; }

    /// <summary>
    /// Entity definition identifier
    /// </summary>
    [JsonPropertyName("__identifier")]
    internal string Identifier { get; set; }

    /// <summary>
    /// Pivot coordinates  (`[x,y]` format, values are from 0 to 1) of the Entity
    /// </summary>
    [JsonPropertyName("__pivot")]
    internal double[] Pivot { get; set; }

    /// <summary>
    /// The entity "smart" color, guessed from either Entity definition, or one its field
    /// instances.
    /// </summary>
    [JsonPropertyName("__smartColor")]
    internal string SmartColor { get; set; }

    /// <summary>
    /// Array of tags defined in this Entity definition
    /// </summary>
    [JsonPropertyName("__tags")]
    internal string[] Tags { get; set; }

    /// <summary>
    /// Optional TilesetRect used to display this entity (it could either be the default Entity
    /// tile, or some tile provided by a field value, like an Enum).
    /// </summary>
    [JsonPropertyName("__tile")]
    internal TilesetRectangleData Tile { get; set; }

    /// <summary>
    /// Reference of the **Entity definition** UID
    /// </summary>
    [JsonPropertyName("defUid")]
    internal long DefUid { get; set; }

    /// <summary>
    /// An array of all custom fields and their values.
    /// </summary>
    [JsonPropertyName("fieldInstances")]
    internal FieldInstanceData[] FieldInstances { get; set; }

    /// <summary>
    /// Entity height in pixels. For non-resizable entities, it will be the same as Entity
    /// definition.
    /// </summary>
    [JsonPropertyName("height")]
    internal long Height { get; set; }

    /// <summary>
    /// Unique instance identifier
    /// </summary>
    [JsonPropertyName("iid")]
    internal Guid Iid { get; set; }

    /// <summary>
    /// Pixel coordinates (`[x,y]` format) in current level coordinate space. Don't forget
    /// optional layer offsets, if they exist!
    /// </summary>
    [JsonPropertyName("px")]
    internal long[] Px { get; set; }

    /// <summary>
    /// Entity width in pixels. For non-resizable entities, it will be the same as Entity
    /// definition.
    /// </summary>
    [JsonPropertyName("width")]
    internal long Width { get; set; }
}
