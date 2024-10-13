using System.Text.Json.Serialization;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkLevel;

internal class LevelBackgroundPositionData
{
    /// <summary>
    /// An array of 4 float values describing the cropped sub-rectangle of the displayed
    /// background image. This cropping happens when original is larger than the level bounds.
    /// Array format: `[ cropX, cropY, cropWidth, cropHeight ]`
    /// </summary>
    [JsonPropertyName("cropRect")]
    internal double[] CropRect { get; set; }

    /// <summary>
    /// An array containing the `[scaleX,scaleY]` values of the **cropped** background image,
    /// depending on `bgPos` option.
    /// </summary>
    [JsonPropertyName("scale")]
    internal double[] Scale { get; set; }

    /// <summary>
    /// An array containing the `[x,y]` pixel coordinates of the top-left corner of the
    /// **cropped** background image, depending on `bgPos` option.
    /// </summary>
    [JsonPropertyName("topLeftPx")]
    internal long[] TopLeftPx { get; set; }
}
