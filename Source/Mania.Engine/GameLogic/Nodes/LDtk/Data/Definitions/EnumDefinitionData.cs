using System.Text.Json.Serialization;

namespace Mania.Engine.GameLogic.Nodes.LDtk.Data.Definitions;

internal class EnumDefinitionData
{
        [JsonPropertyName("externalFileChecksum")]
        internal string ExternalFileChecksum { get; set; }

        /// <summary>
        /// Relative path to the external file providing this Enum
        /// </summary>
        [JsonPropertyName("externalRelPath")]
        internal string ExternalRelPath { get; set; }

        /// <summary>
        /// Tileset UID if provided
        /// </summary>
        [JsonPropertyName("iconTilesetUid")]
        internal long? IconTilesetUid { get; set; }

        /// <summary>
        /// User defined unique identifier
        /// </summary>
        [JsonPropertyName("identifier")]
        internal string Identifier { get; set; }

        /// <summary>
        /// An array of user-defined tags to organize the Enums
        /// </summary>
        [JsonPropertyName("tags")]
        internal string[] Tags { get; set; }

        /// <summary>
        /// Unique Int identifier
        /// </summary>
        [JsonPropertyName("uid")]
        internal long Uid { get; set; }

        /// <summary>
        /// All possible enum values, with their optional Tile infos.
        /// </summary>
        [JsonPropertyName("values")]
        internal EnumValueDefinitionData[] Values { get; set; }
}
