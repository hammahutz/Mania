using System.Text.Json.Serialization;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkDefinitions;


internal class DefinitionsData
{
    /// <summary>
    /// All entities definitions, including their custom fields
    /// </summary>
    [JsonPropertyName("entities")]
    internal EntityDefinitionData[] Entities { get; set; }

    /// <summary>
    /// All internal enums
    /// </summary>
    [JsonPropertyName("enums")]
    internal EnumDefinitionData[] Enums { get; set; }

    /// <summary>
    /// Note: external enums are exactly the same as `enums`, except they have a `relPath` to
    /// point to an external source file.
    /// </summary>
    [JsonPropertyName("externalEnums")]
    internal EnumDefinitionData[] ExternalEnums { get; set; }

    /// <summary>
    /// All layer definitions
    /// </summary>
    [JsonPropertyName("layers")]
    internal LayerDefinitionData[] Layers { get; set; }

    /// <summary>
    /// All custom fields available to all levels.
    /// </summary>
    [JsonPropertyName("levelFields")]
    internal FieldDefinitionData[] LevelFields { get; set; }

    /// <summary>
    /// All tilesets
    /// </summary>
    [JsonPropertyName("tilesets")]
    internal TilesetDefinitionData[] Tilesets { get; set; }
}
