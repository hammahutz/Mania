using System.Text.Json.Serialization;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkTileset;

internal class TilesetRectangleData
{
  /// <summary>
  /// Height in pixels
  /// </summary>
  [JsonPropertyName("h")]
  internal long H { get; set; }

  /// <summary>
  /// UID of the tileset
  /// </summary>
  [JsonPropertyName("tilesetUid")]
  internal long TilesetUid { get; set; }

  /// <summary>
  /// Width in pixels
  /// </summary>
  [JsonPropertyName("w")]
  internal long W { get; set; }

  /// <summary>
  /// X pixels coordinate of the top-left corner in the Tileset image
  /// </summary>
  [JsonPropertyName("x")]
  internal long X { get; set; }

  /// <summary>
  /// Y pixels coordinate of the top-left corner in the Tileset image
  /// </summary>
  [JsonPropertyName("y")]
  internal long Y { get; set; }
}
