using System.Text.Json.Serialization;

namespace Mania.Library.LDtk.Definitions;


public class DefinitionsData
{
    /// <summary>
    /// All entities definitions, including their custom fields
    /// </summary>
    [JsonPropertyName("entities")]
    public EntityDefinitionData[] Entities { get; set; }

    /// <summary>
    /// All public enums
    /// </summary>
    [JsonPropertyName("enums")]
    public EnumDefinitionData[] Enums { get; set; }

    /// <summary>
    /// Note: external enums are exactly the same as `enums`, except they have a `relPath` to
    /// point to an external source file.
    /// </summary>
    [JsonPropertyName("externalEnums")]
    public EnumDefinitionData[] ExternalEnums { get; set; }

    /// <summary>
    /// All layer definitions
    /// </summary>
    [JsonPropertyName("layers")]
    public LayerDefinitionData[] Layers { get; set; }

    /// <summary>
    /// All custom fields available to all levels.
    /// </summary>
    [JsonPropertyName("levelFields")]
    public FieldDefinitionData[] LevelFields { get; set; }

    /// <summary>
    /// All tilesets
    /// </summary>
    [JsonPropertyName("tilesets")]
    public TilesetDefinitionData[] Tilesets { get; set; }
}
